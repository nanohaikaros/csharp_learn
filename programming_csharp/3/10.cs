using System;
using System.Collections.Generic;
using System.Text;

namespace UsingGoTo
{
    class UsingGoTo
    {
        static void Main(string[] args)
        {
            int i = 0;
        repeat:         // 行标
            Console.WriteLine("i: {0}", i);
            i++;
            if (i < 10)
                goto repeat;
            return;
        }
    }
}