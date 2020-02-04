using System;
using System.Collections.Generic;
using System.Text;

namespace ReturningValuesInParams
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

        public void GetTime(ref int h, ref int m, ref int s)
        {
            h = Hour;
            m = Minute;
            s = Second;
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

            int theHour = 0;
            int theMinute = 0;
            int theSecond = 0;
            t.GetTime(ref theHour, ref theMinute, ref theSecond);
            System.Console.WriteLine("Current time: {0}:{1}:{2}", theHour, theMinute, theSecond);
        }
    }
}