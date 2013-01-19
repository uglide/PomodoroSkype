using System;
using System.Timers;

namespace PomodoroSkype.Models
{
    class Timer:System.Timers.Timer
    {
        private int _timeInSec = 0;
        private bool _timerRunning = false;

        public delegate void TimeElapsedEventHandler(object sender, ElapsedEventArgs e);

        public event TimeElapsedEventHandler TimeElapsed;
        public event TimeElapsedEventHandler OnTick;

        public Timer()
        {
            Interval = 1000;
            Elapsed += DecreaseTime;
        }

        private void DecreaseTime(object source, ElapsedEventArgs e)
        {
            _timeInSec--;

            if (_timeInSec == 0)
            {
                Stop();                
            } else
            {
                OnTick(this, (ElapsedEventArgs)null);
            }
        }

        public void Start(int timeIntervalInSec)
        {
            _timeInSec = timeIntervalInSec;
            _timerRunning = true;
            base.Start();            
        }

        public new void Stop()
        {
            _timerRunning = false;
            base.Stop();
            TimeElapsed(this, (ElapsedEventArgs)null);
        }

        public string GetTime()
        {
            TimeSpan t = TimeSpan.FromSeconds(_timeInSec);

            return string.Format("{0:D2}:{1:D2}",     			
    			t.Minutes, 
    			t.Seconds
            );
        }

        public int GetSeconds()
        {
            return _timeInSec;
        }

        public bool IsRunning()
        {
            return _timerRunning;
        }

    }
}
