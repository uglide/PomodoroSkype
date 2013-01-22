    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroSkype.Models
{
    class Task : ITask
    {
        public long Id { get; set; }

        public string Name { get; set; }
        
        public long EstimatedPomodorosCount { get; set; }

        public long InterruptionsCount { get; set; }

        public long CompletedPomodorosCount { get; set; }

        public long UnplannedTasksCount { get; set; }

        public bool Done { get; set; }

        public bool Deleted { get; set; }

        public bool IsValid()
        {
            return (EstimatedPomodorosCount > 0 && EstimatedPomodorosCount < 9) 
                && Name.Length > 0;
        }

    }
}

