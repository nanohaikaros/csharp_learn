#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace StaticPublicConstants
{
    public class RightNow
    {
        // 公共成员变量
        public static readonly int Year;
        public static readonly int Month;
        public static readonly int Date;
        public static readonly int Hour;
        public static readonly int Minute;
        public static readonly int Second;

        static RightNow()
        {
            System.DateTime dt = System.DateTime.Now;
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
            System.Console.WriteLine("This year: {0}", RightNow.Year.ToString());
            // RightNow.Year = 2006;    // Error
            System.Console.WriteLine("This year: {0}", RightNow.Year.ToString());
        }
    }
}