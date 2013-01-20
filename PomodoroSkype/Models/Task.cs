using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroSkype.Models
{
    class Task
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EstimatedPomodorosCount { get; set; }

        public int InterruptionsCount { get; set; }

        public int CompletedPomodorosCount { get; set; }

        public int UnplannedTasksCount { get; set; }

        public bool Done { get; set; }

    }
}
