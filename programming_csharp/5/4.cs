#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace boxing
{
    public class UnboxingTest
    {
        public static void Main()
        {
            int i = 123;

            // 装箱
            object o = i;

            // 拆箱(必须显示)
            int j = (int)o;
            Console.WriteLine("j: {0}", j);
        }
    }
}