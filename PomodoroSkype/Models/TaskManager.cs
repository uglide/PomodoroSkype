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
