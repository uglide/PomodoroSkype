using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using PomodoroSkype.ExternalComponents;

namespace PomodoroSkype.Models
{
    class TaskManager : BaseManager
    {

        private static readonly TaskManager TheInstance = new TaskManager();

        private TaskManager()
        {
            Table = "tasks";

        }        

        public static TaskManager Instance
        {
            get { return TheInstance; }
        }


        private static string GetAllEntitiesQuery()
        {
            return @"SELECT 
			            t.id, t.name, t.estimated, 	                
			            (SELECT COUNT(p.id) 
					            FROM pomodoros as p 
					            WHERE t.id = p.taskId)  as pomodorosCount,
			            (SELECT COUNT(i.id) 
					            FROM interruptions as i 
					            WHERE t.id = i.taskId)  as interruptionsCount,
			            (SELECT COUNT(un.id)
					            FROM unplanned_tasks as un 
					            WHERE t.id = un.sourceTaskId
			            ) as unplannedTasksCount
		            FROM tasks as t 
		            WHERE t.deleted <> 1";
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


        public override DbFeildMap[] GetFieldsMapping()
        {
            DbFeildMap[]  mapping = {                
                new DbFeildMap ("Id", "id", "tasks", true),
                new DbFeildMap ("Name", "name", "tasks"),
                new DbFeildMap ("EstimatedPomodorosCount", "estimated", "tasks"),
                new DbFeildMap ("Done", "done", "tasks"),
                new DbFeildMap ("Deleted", "deleted", "tasks"),                
            };

            return mapping;
        }
    }

 
}
