using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadedConstructor
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

        // 构造方法
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Date;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        public Time(int Year, int Month, int Date, int Hour, int Minute, int Second)
        {
            this.Year = Year;
            this.Month = Month;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }
    }

    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;

            Time t1 = new Time(currentTime);
            t1.DisplayCurrentTime();

            Time t2 = new Time(2005, 11, 18, 11, 03, 30);
            t2.DisplayCurrentTime();
        }
    }
}