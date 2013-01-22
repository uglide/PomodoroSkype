using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using PomodoroSkype.ExternalComponents;

namespace PomodoroSkype.Models
{
    abstract class BaseManager
    {

        public const string InsertQuery = "insert";
        public const string UpdateQuery = "update"; 

        /*
         * Db fields mapping
         */
        abstract public DbFeildMap[] GetFieldsMapping();        

        /*
         * Table name in db
         */
        public static string Table;


        /*
         * Add model to db
         */
        public int Add(Object t)
        {
            return BuildQueryFromObjectAndExecute(t, InsertQuery);
        }

        /*
         * Update model in db
         */
        public int Update(Object t)
        {
            return BuildQueryFromObjectAndExecute(t, UpdateQuery);
        }

        /*
         * Query builder
         */
        private int BuildQueryFromObjectAndExecute(object model, string queryType = InsertQuery)
        {
            var db = DbHelper.Connect();
            
            SQLiteCommand command = db.CreateCommand();
            var fieldsMapping = GetFieldsMapping();
            var properties = model.GetType().GetProperties();

            var fieldNames = new List<string>();
            var paramNames = new List<string>();

            foreach (var prop in properties)
            {
                var propName = prop.Name;
                var fieldName =
                    from field in fieldsMapping
                    where field.PropertyName == propName
                    select field;

                var dbFeildMaps = fieldName as DbFeildMap[] ?? fieldName.ToArray();
                if (!dbFeildMaps.Any()) continue;

                var fieldData = dbFeildMaps.First();
                if (!fieldData.PrimaryKey)
                {
                    fieldNames.Add(fieldData.FieldName);
                    paramNames.Add("@Param" + propName);
                }
                command.Parameters.AddWithValue("@Param" + propName, prop.GetValue(model, null));
            }

            if (queryType == InsertQuery)
            {
                command.CommandText = BuildInsertQuery(fieldNames, paramNames);

            } else if (queryType == UpdateQuery)
            {
                command.CommandText = BuildUpdateQuery(fieldNames, paramNames);
            }

            return command.ExecuteNonQuery();
             
        }

        private string BuildInsertQuery(IEnumerable<string> fieldNames, IEnumerable<string> paramNames)
        {
            return @"INSERT INTO "
                            + Table + " ( " + String.Join(",", fieldNames)
                            + ") VALUES (" + String.Join(",", paramNames) + ")";
        }

        private string BuildUpdateQuery(IEnumerable<string> fieldNames, IEnumerable<string> paramNames)
        {
            var fieldsMapping = GetFieldsMapping();

            var primaryKey =
                    from field in fieldsMapping
                    where field.PrimaryKey
                    select field;

            var dbFeildMaps = primaryKey as DbFeildMap[] ?? primaryKey.ToArray();
            if (!dbFeildMaps.Any()) throw new Exception("Primary Key not founded in fields mapping!");

            var pk = dbFeildMaps.First();

            return @"UPDATE " + Table + " SET "
                    + String.Join(", ", fieldNames.Zip(paramNames, (field, param) => field + "=" + param).ToArray())
                    + " WHERE " + pk.FieldName + "=@Param" + pk.PropertyName;
        }
    }
    
    internal class DbFeildMap
    {
        public string PropertyName;
        public string FieldName;
        public string Table;
        public bool PrimaryKey;
        public bool CalcField;

        public DbFeildMap(string property, string field, string tbl, bool pk = false)
        {
            PropertyName = property;
            FieldName = field;
            Table = tbl;
            PrimaryKey = pk;
        }
    }
}
