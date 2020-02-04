using System;
using System.Collections.Generic;
using System.Text;

namespace Initializer
{
    public class Time
    {
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second = 30;        // 初始化语句

        // 公共访问方法
        public void DisplayCurrentTime()
        {
            System.DateTime now = System.DateTime.Now;
            System.Console.WriteLine("\nDebug\t: {0}/{1}/{2} {3}:{4}:{5}", now.Month, now.Date, now.Year, now.Hour, now.Minute, now.Second);

            System.Console.WriteLine("Time\t: {0}/{1}/{2} {3}:{4}:{5}", Month, Date, Year, Hour, Minute, Second);
        }

        // 构造方法
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Date;
            Hour = dt.Hour;
            Minute = dt.Hour;
            Second = dt.Second;
        }

        public Time(int Year, int Month, int Date, int Hour, int Minute)
        {
            this.Year = Year;
            this.Month = Minute;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
        }
    }

    public class Tester 
    {
        static void Mian()
        {
            System.DateTime currentTIme = System.DateTime.Now;
            Time t = new Time(currentTIme);
            t.DisplayCurrentTime();

            Time t2 = new Time(2005, 11, 18, 11, 45);
            t2.DisplayCurrentTime();
        }
    }
}