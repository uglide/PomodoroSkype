using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using PomodoroSkype.ExternalComponents;

namespace PomodoroSkype.Models
{
    static class TaskManager
    {

        public static string Table = "tasks";

        //only for internal fields which we can save
        public static DbFiledMap[] FieldsMapping =
            {                
                new DbFiledMap ("Id", "id", "tasks", true),
                new DbFiledMap ("Name", "name", "tasks"),
                new DbFiledMap ("EstimatedPomodorosCount", "estimated", "tasks"),
                new DbFiledMap ("Done", "done", "tasks"),
                new DbFiledMap ("Deleted", "deleted", "tasks"),                
            };

        private static string GetAllEntitiesQuery()
        {
            return @"SELECT 
	                t.id, t.name, t.estimated, 
	                COUNT(p.id) as pomodorosCount, 
	                COUNT(i.id) as interruptionsCount,
	                COUNT(un.id) as unplannedTasksCount
                FROM tasks as t 
	                LEFT JOIN pomodoros as p ON t.id = p.taskId
	                LEFT JOIN interruptions as i ON t.id = i.taskId
	                LEFT JOIN unplanned_tasks as un ON t.id = un.sourceTaskId
                WHERE
		            t.deleted <> 1";
        }

        public static List<Task> GetAllTasks()
        {
            var tasks = new List<Task>();
            var reader = DbHelper.Select(GetAllEntitiesQuery());

            while (reader.Read())
            {
                tasks.Add(new Task
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    CompletedPomodorosCount = reader.GetInt32(3),
                    EstimatedPomodorosCount = reader.GetInt32(2),
                    InterruptionsCount = reader.GetInt32(4),
                    UnplannedTasksCount = reader.GetInt32(5)
                });
            }
            
            return tasks;
        }

        public static void Add(Task t)
        {            
            string query = @"INSERT INTO " + Table;
            List<string> fieldNames = new List<string>();

            var properties = t.GetType().GetProperties();
            var db = DbHelper.Connect();
            SQLiteCommand command = db.CreateCommand();

            foreach (var prop in properties)
            {
                //prop.Name, 
                var propName = prop.Name;

                var fieldName =
                    (from field in FieldsMapping
                     where field.PropertyName == propName && !field.PrimaryKey 
                     select field.FieldName).FirstOrDefault();

                if (null != fieldName)
                {
                    fieldNames.Add(fieldName);
                    command.Parameters.AddWithValue("@Param" + propName, prop.GetValue(t, null));
                }
            }

        }
    }

    internal class DbFiledMap
    {
        public string PropertyName;
        public string FieldName;
        public string Table;
        public bool PrimaryKey;
        public bool CalcField;

        public DbFiledMap(string property, string field, string tbl, bool pk = false)
        {
            PropertyName = property;
            FieldName = field;
            Table = tbl;
            PrimaryKey = pk;
        }
    }
}
