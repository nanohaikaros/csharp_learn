#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
#endregion

namespace EventsWithDelegates
{
    public class TimeInfoEventArgs : EventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
    }

    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void SecondChangeHandler(object Clock, TimeInfoEventArgs timeImformation);

        public SecondChangeHandler OnSecondChange;

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(10);

                System.DateTime dt = System.DateTime.Now;

                if (dt.Second != second)
                {
                    TimeInfoEventArgs timeinformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    if (OnSecondChange != null)
                    {
                        OnSecondChange(this, timeinformation);
                    }
                }

                this.second = dt.Second;
                this.minute = minute;
                this.hour = hour;
            }
        }
    }

    public class DisplayClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }

    public class LogCurrentTime
    {
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(WriteLogEntry);
        }

        public void WriteLogEntry(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }

    public class Test
    {
        public static void Main()
        {
            Clock theClock = new Clock();

            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            LogCurrentTime lct = new LogCurrentTime();
            lct.Subscribe(theClock);

            theClock.Run();
        }
    }   
}