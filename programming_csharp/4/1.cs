using System;
using System.Collections.Generic;
using System.Text;

namespace TimeClass
{
    public class Time
    {
        // 私有变量
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Seconde;

        // 公共方法
        public void DisplayCurrentTime()
        {
            Console.WriteLine("stub for DisplayCurrentTime");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Time t = new Time();
            t.DisplayCurrentTime();
        }
    }
}