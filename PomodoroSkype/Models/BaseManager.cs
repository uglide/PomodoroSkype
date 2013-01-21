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
            var fieldNames = new List<string>();
            var paramNames = new List<string>();

            var properties = t.GetType().GetProperties();
            var db = DbHelper.Connect();
            SQLiteCommand command = db.CreateCommand();
            var fieldsMapping = GetFieldsMapping();

            foreach (var prop in properties)
            {
                //prop.Name, 
                var propName = prop.Name;
                

                var fieldName =
                    from field in fieldsMapping
                     where field.PropertyName == propName && !field.PrimaryKey
                     select field;

                if (!fieldName.Any()) continue;

                fieldNames.Add(fieldName.First().FieldName);
                paramNames.Add("@Param" + propName);
                command.Parameters.AddWithValue("@Param" + propName, prop.GetValue(t, null));
            }

            command.CommandText = @"INSERT INTO "
                                  + Table + " ( " + String.Join(",", fieldNames)
                                  + ") VALUES (" + String.Join(",", paramNames) + ")";

            return command.ExecuteNonQuery();
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
