using System;
using System.Collections.Generic;
using System.Text;

namespace InOutRef
{
    public class Time
    {
        // 私有成员变量
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;

        // 公共访问方法
        public void DisplayCurrentTime()
        {
            System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", Month, Date, Year, Hour, Minute, Second);
        }

        public int GetHour()
        {
            return Hour;
        }

        public void SetTime(int hr, out int min, ref int sec)
        {
            if (sec >= 30)
            {
                Minute++;
                Second = 0;
            }
            Hour = hr;

            min = Minute;
            sec = Second;
        }

        // 构造方法
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
    }

    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();

            int theHour = 3;
            int theMinute;
            int theSecond = 20;

            t.SetTime(theHour, out theMinute, ref theSecond);
            System.Console.WriteLine("the Minute is now: {0} and {1} seconds", theMinute, theSecond);

            theSecond = 40;
            t.SetTime(theHour, out theMinute, ref theSecond);
            System.Console.WriteLine("the Minute is now: " + "{0} and {1} seconds", theMinute, theSecond);
        }
    }
}