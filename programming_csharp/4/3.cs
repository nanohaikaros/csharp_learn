using System;
using System.Collections.Generic;
using System.Text;

namespace DeclaringConstructor
{
    public class Time
    {
        // 私有成员变量
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;

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
    }

    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
        }
    }
}