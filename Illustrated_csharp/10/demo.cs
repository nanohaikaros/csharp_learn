using System;

namespace Demo
{
    // struct Point
    // {
    //     public int X;
    //     public int Y;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Point first, second, third;

    //         first.X = 10; first.Y = 10;
    //         second.X = 20; second.Y = 20;
    //         third.X = first.X + second.X;
    //         third.Y = first.Y + second.Y;

    //         Console.WriteLine("first: {0}, {1}", first.X, first.Y);
    //         Console.WriteLine("second: {0}, {1}", second.X, second.Y);
    //         Console.WriteLine("third: {0}, {1}", third.X, third.Y);
    //     }
    // }

    // class CSimple
    // {
    //     public int X;
    //     public int Y;
    // }

    // struct Simple
    // {
    //     public int X;
    //     public int Y;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         CSimple cs1 = new CSimple(), cs2 = null;
    //         Simple ss1 = new Simple(), ss2 = new Simple();

    //         cs1.X = ss1.X = 5;
    //         cs1.Y = ss1.Y = 10;

    //         cs2 = cs1;
    //         ss2 = ss1;
    //     }
    // }

    // struct Simple
    // {
    //     public int X;
    //     public int Y;

    //     public Simple(int a, int b)
    //     {
    //         X = a;
    //         Y = b;
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Simple s1 = new Simple();
    //         Simple s2 = new Simple(5, 10);

    //         Console.WriteLine("{0}, {1}", s1.X, s1.Y);
    //         Console.WriteLine("{0}, {1}", s2.X, s2.Y);
    //     }
    // }

    struct Simple
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main()
        {
            Simple s1, s2;
            Console.WriteLine("{0}, {1}", s1.X, s1.Y);  // error

            s2.X = 5;
            s2.Y = 10;
            Console.WriteLine("{0}, {1}", s2.X, s2.Y);
        }
    }
}