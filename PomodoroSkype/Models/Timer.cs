using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroSkype.Models
{
    class Timer:System.Timers.Timer
    {
        private int _timeInSec = 0;
        private bool _timerRunning = false;

        public Timer()
        {
            Interval = 1000;
        }

        public void Start(int timeIntervalInSec)
        {
            _timeInSec = timeIntervalInSec;
            _timerRunning = true;
            base.Start();            
        }

        public void Stop()
        {
            _timerRunning = false;
            base.Stop();
        }

        public string getTime()
        {
            TimeSpan t = TimeSpan.FromSeconds(_timeInSec);

            return string.Format("{1:D2}m:{2:D2}s",     			
    			t.Minutes, 
    			t.Seconds
            );
        }

    }
}
