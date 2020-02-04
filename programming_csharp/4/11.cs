#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace UsingAProperty
{
    public class Time
    {
        // 私有成员变量
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        // 公共访问方法
        public void DisplayCurrentTime()
        {
            System.Console.WriteLine("Time\t: {0}/{1}/{2} {3}:{4}:{5}", month, date, year, hour, minute, second);
        }

        // 构造方法
        public Time(System.DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            date = dt.Day;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }

        // 创建一个属性
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
            }
        }
    }

    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();

            int theHour = t.Hour;
            System.Console.WriteLine("\nRetrieved the hour: {0}\n", theHour);
            theHour++;
            t.Hour = theHour;
            System.Console.WriteLine("Updated the hour: {0}\n", theHour);
        }
    }
}