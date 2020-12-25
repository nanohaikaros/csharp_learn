using System;           

namespace Demo
{
    class Program
    {
        static void Main()
        {
            int var1 = 5;
            System.Console.WriteLine("The value of var1 is {0}", var1);

            System.Console.Write("This is text1. ");
            System.Console.Write("This is text2. ");
            System.Console.Write("This is text3. ");

            System.Console.WriteLine("This is text1. ");
            System.Console.WriteLine("This is text2. ");
            System.Console.WriteLine("This is text3. ");

            Console.WriteLine("Two sample integers are {0} and {1}.", 3, 6);

            //Console.WriteLine("Three integers are {0} and {2}.", 3, 6); // Error

            Console.WriteLine("The value: {0}.", 500);      // 输出数字
            Console.WriteLine("The value: {0:C}.", 500);    // 格式为货币

            Console.WriteLine("{0, 10}", 500);

            int myInt = 500;
            Console.WriteLine("|{0, 10}|", myInt);      // 右对齐
            Console.WriteLine("{0, -10}|", myInt);      // 左对齐

            Console.WriteLine("{0:F4}", 12.345678);

            double myDouble = 12.345678;
            Console.WriteLine("{0,-10:G} -- General", myDouble);
            Console.WriteLine("{0, -10} -- Default, same as General", myDouble);
            Console.WriteLine("{0, -10:F4} -- Fixed Point, 4 dec places", myDouble);
            Console.WriteLine("{0, -10:C} -- Currency", myDouble);
            Console.WriteLine("{0, -10:E3} -- Sci. Notation, 3 dec places", myDouble);
            Console.WriteLine("{0, -10:x} -- Hexadecimal integer", 1194719);
        }
    }
}