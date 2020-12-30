using System;
using System.Reflection;

namespace Demo
{
    class MyClass
    {
        static void Main()
        {
            Console.WriteLine("{0}", 1024);
            Console.WriteLine("{0}", 3.1416);
            Console.WriteLine("{0}", 3.1416F);
            Console.WriteLine("{0}", true);
            Console.WriteLine("{0}", 'x');
            Console.WriteLine("{0}", "Hi there");

            236;
            236L;
            236U;
            236UL;

            float f1 = 236F;
            double d1 = 236.714;
            double d2 = .35192;
            double d3 = 6.338e-26;

            char c1 = 'd';
            char c2 = '\n';
            char c3 = '\x0061';
            char c4 = '\u005a';

            string st1 = "Hi there!";
            string st2 = "Val1\t5, Val2\t10";
            string st3 = "Add\x000ASome\u0007Interest";

            string rst1 = "Hi there!";
            string vst1 = @"Hi there!";

            string rst2 = "It started, \"Four score and seven...\"";
            string vst2 = @"It started, ""Four score and seven...""";

            string rst3 = "Value 1 \t 5, Val2 \t 10";
            string vst3 = @"Value 1 \t 5, Val2 \t 10";

            string rst4 = "C:\\Program Files\\Microsoft\\";
            string vst4 = @"C:\\Program Files\Microsoft\";

            string rst5 = " Print \x000A Multiple \u000A Lines";
            string vst5 = @" Print
            Multiple
            Lines";

            int x1 = 5 + 6;
            int x2 = 12 - 3;
            int x3 = 3 * 4;
            int x4 = 10 / 3;

            byte b1 = 5 + 6;
            sbyte sb1 = 6 * 5;

            Console.WriteLine("0.0f % 1.5f is {0}", 0.0f % 1.5f);
            Console.WriteLine("0.5f % 1.5f is {0}", 0.5f % 1.5f);
            Console.WriteLine("1.0f % 1.5f is {0}", 1.0f % 1.5f);
            Console.WriteLine("1.5f % 1.5f is {0}", 1.5f % 1.5f);
            Console.WriteLine("2.0f % 1.5f is {0}", 2.0f % 1.5f);
            Console.WriteLine("2.5f % 1.5f is {0}", 2.5f % 1.5f);

            int x = 5, y = 4;
            Console.WriteLine("x == x is {0}", x == x);
            Console.WriteLine("x == y is {0}", x == y);

            int x = 5, y;
            y = x++;    // y=5, x=6
            Console.WriteLine("y: {0}, x:{1}", y, x);

            x = 5;
            y = ++x;    // y=6, x=6
            Console.WriteLine("y: {0}, x: {1}", y, x);

            x = 5;
            y = x--;    // y=5, x=4
            Console.WriteLine("y: {0}, x: {1}", y, x);

            x = 5;
            y = --x;    // y= 4, x=4
            Console.WriteLine("y: {0}, x: {1}", y, x);

            bool bVal;
            bVal = (1 == 1) && (2 == 2);    //true
            bVal = (1 == 1) && (1 == 2);    //false
            bVal = (1 == 1) || (1 == 2);    //true

            bVal = (1 == 1) || (2 == 2);    //true
            bVal = (1 == 1) || (1 == 2);    //true
            bVal = (1 == 2) || (2 == 3);    //false

            bVal = true;
            bVal = !bVal;

            bool bVal; int iVal = 10;
            bVal = (1 == 2) && (9 == iVal++);   // bVal=false, iVal=10

            const byte x = 12, y = 10;
            sbyte a;

            a = x & y;  //a=8
            a = x | y;  //a=14
            a = x ^ y;  //a=6
            a = ~x;     //a=-13

            int a, b, x = 14;
            a = x << 3;
            b = x >> 3;

            Console.WriteLine("{0} << 3 = {1}", x, a);
            Console.WriteLine("{0} >> 3 = {1}", x, b);

            int x = 10, y = 9;
            int highVal = x > y ? x : y;

            Console.WriteLine("highVal: {0}\n", highVal);
            Console.WriteLine("x is{0} greater than y", x > y ? "" : " not");
        }
    }

    // class LimitedInt
    // {
    //     public static implicit operator int (LimitedInt li)
    //     {
    //         return li.TheValue();
    //     }

    //     public static implicit operator LimitedInt(int x)
    //     {
    //         LimitedInt li = new LimitedInt();
    //         li.TheValue = x;
    //         return li;
    //     }

    //     private int _theValue = 0;
    //     public int TheValue
    //     {
    //         get { return _theValue; }
    //         set
    //         {
    //             if (value < MinValue)
    //                 _theValue = 0;
    //             else
    //                 _theValue = value > MaxValue ? MaxValue : value;
    //         }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         LimitedInt li = 500;
    //         int value = li;

    //         Console.WriteLine("li: {0}, value: {1}", li.TheValue, value);
    //     }
    // }



    /* class LimitedInt
        {
            public static explicit operator int (LimitedInt li)
            {
                return li.TheValue();
            }

            public static explicit operator LimitedInt(int x)
            {
                LimitedInt li = new LimitedInt();
                li.TheValue = x;
                return li;
            }

            public static LimitedInt operator + (LimitedInt x, double y)
            {
                LimitedInt li = new LimitedInt();
                li.TheValue = x.TheValue + (int)y;
            }

            public static LimitedInt operator -(LimitedInt x)
            {
                LimitedInt li = new LimitedInt();
                li.TheValue = 0;
                return li;
            }

            private int _theValue = 0;
            public int TheValue
            {
                get { return _theValue; }
                set
                {
                    if (value < MinValue)
                        _theValue = 0;
                    else
                        _theValue = value > MaxValue ? MaxValue : value;
                }
            }
        }

        class Program
        {
            static void Main()
            {
                LimitedInt li = (LimitedInt)500;
                int value = (int)li;

                Console.WriteLine("li: {0}, value: {1}", li.TheValue, value);
            }
        }
    } */

    // class LimitedInt
    // {
    //     const int MaxValue = 100;
    //     const int MinValue = 0;

    //     public static LimitedInt operator -(LimitedInt x)
    //     {
    //         LimitedInt li = new LimitedInt();
    //         li.TheValue = 0;
    //         return li;
    //     }

    //     public static LimitedInt operator -(LimitedInt x, LimitedInt y)
    //     {
    //         LimitedInt li = new LimitedInt();
    //         li.TheValue = x.TheValue - y.TheValue;
    //         return li;
    //     }

    //     public static LimitedInt operator +(LimitedInt x, double y)
    //     {
    //         LimitedInt li = new LimitedInt();
    //         li.TheValue = x.TheValue + (int)y;
    //         return li;
    //     }

    //     private int _theValue = 0;

    //     public int TheValue
    //     {
    //         get { return _theValue; }
    //         set
    //         {
    //             if (value < MinValue)
    //                 _theValue = 0;
    //             else
    //                 _theValue = value > MaxValue ? MaxValue : value;
    //         }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         LimitedInt li1 = new LimitedInt();
    //         LimitedInt li2 = new LimitedInt();
    //         LimitedInt li3 = new LimitedInt();
    //         li1.TheValue = 10; li2.TheValue = 26;
    //         Console.WriteLine(" li1: {0}, li2: {1}", li1.TheValue, li2.TheValue);

    //         li3 = -li1;
    //         Console.WriteLine("-{0} = {1}", li1.TheValue, li3.TheValue);

    //         li3 = li2 - li1;
    //         Console.WriteLine(" {0} - {1} = {2}", li2.TheValue, li1.TheValue, li3.TheValue);

    //         li3 = li1 - li2;
    //         Console.WriteLine(" {0} - {1} = {2}", li1.TheValue, li2.TheValue, li3.TheValue);
    //     }
    // }


    class SomeClass
    {
        public int Field1;
        public int Fiedld2;

        public void Method1() { }
        public int Method2() { return 1; }
    }

    class Program
    {
        static void Main()
        {
            Type t = typeof(SomeClass);
            FieldInfo[] fi = t.GetFields();
            MethodInfo[] mi = t.GetMethods();

            foreach (FieldInfo f in fi)
                Console.WriteLine("Firld : {0}", f.Name);
            foreach (MethodInfo m in mi)
                Console.WriteLine("Method: {0}", m.name);

            SomeClass s = new SomeClass();
            Console.WriteLine("Type s: {0}", s.GetType().Name);
        }
    }
}