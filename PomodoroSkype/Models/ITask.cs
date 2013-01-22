using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroSkype.Models
{
    interface ITask
    {
        long Id { get; set; }

        string Name { get; set; }

        long EstimatedPomodorosCount { get; set; }

        long InterruptionsCount { get; set; }

        long CompletedPomodorosCount { get; set; }

        long UnplannedTasksCount { get; set; }

        bool Done { get; set; }

        bool Deleted { get; set; }
    }
}
