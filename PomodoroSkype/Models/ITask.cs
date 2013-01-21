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

        int EstimatedPomodorosCount { get; set; }

        int InterruptionsCount { get; set; }

        int CompletedPomodorosCount { get; set; }

        int UnplannedTasksCount { get; set; }

        bool Done { get; set; }

        bool Deleted { get; set; }
    }
}
