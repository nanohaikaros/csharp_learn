using System;

namespace Demo
{
    /* class Program
    {
        void MyMethod()
        {
            Console.WriteLine("First");
            Console.WriteLine("Last");
        }

        static void Main()
        {
            // int total = 15;
            // MyMethod mec = new MyMethod();
            var total = 15;
            var mec = new MyMethod();
        }

        void DisplayRadii()
        {
            const double PI = 3.1416;

            for (int radius = 1; radius <= 5; radius++)
            {
                double area = radius * radius * PI;
                Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            }
        }

        void SomeMethod()
        {
            int intVal = 3;

            if (intVal == 3)
            {
                Console.WriteLine("Value is 3.");   // if语句
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Value of i: {0}", i);    // for语句
            }
        }
    } */

    /* class MyClass       // 声明方法
    {
        void PrintDateAndTime()
        {
            DateTime dt = DateTime.Now;       // 获取当前时间
            Console.WriteLine("{0}", dt);       // 输出
        }

        // static void Main()      // 声明方法
        // {
        //     MyClass mc = new MyClass();
        //     mc.PrintDateAndTime();      // 调用方法
        // }

        public int GetHour()
        {
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;

            return hour;
        }

        MyClass method3()
        {
            MyClass mc = new MyClass();
            return mc;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            Console.WriteLine("Hour: {0}", mc.GetHour());
        }
    } */

    // class MyClass
    // {
        // void TimeUpdate()
        // {
        //     DateTime dt = DateTime.Now;
        //     if (dt.Hour < 12)   
        //         return;         // 返回 
        //     Console.WriteLine("It's afternoom!");   // 否则，输出消息
        // }

        // static void Main()
        // {
        //     MyClass mc = new MyClass(); // 创建一个类实例
        //     mc.TimeUpdate();        // 调用方法
        // }

        // PrintSum(5, someInt);

        // public void PrintSum(int x, int y)
        // {
        //     int sum = x + y;
        //     Console.WriteLine("Newsflash: {0} + {1} is {2}", x, y, sum);
        // }

    //     public int Sum(int x, int y)
    //     {
    //         return x + y;
    //     }

    //     public float Avg(float input1, float input2)
    //     {
    //         return (input1 + input2) / 2.0F;
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyClass myT = new MyClass();
    //         int someInt = 6;

    //         Console.WriteLine("Newsflash: Sum: {0} and {1} is {2}", 5, someInt, myT.Sum(5, someInt));

    //         Console.WriteLine("Newsflash: Avg: {0} and {1} is {2}", 5, someInt, myT.Avg(5, someInt));
    //     }
    // }

    class MyClass
    {
        public int Val = 20;
    }

    class Program
    {
        static void MyMethod(MyClass f1, int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
        }

        static void Main()
        {
            MyClass a1 = new MyClass();
            int a2 = 10;

            MyMethod(a1, a2);
            Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);
            Console.
        }
    }
}