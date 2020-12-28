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

    // class MyClass
    // {
    //     public int Val = 20;
    // }

    // class Program
    // {
    //     static void MyMethod(MyClass f1, int f2)
    //     {
    //         f1.Val = f1.Val + 5;
    //         f2 = f2 + 5;
    //         Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
    //     }

    //     static void Main()
    //     {
    //         MyClass a1 = new MyClass();
    //         int a2 = 10;

    //         MyMethod(a1, a2);
    //         Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);
    //     }
    // }

    // class MyClass
    // {
    //     public int Val = 20;
    // }

    // class Program 
    // {
    //     static void MyMethod(ref MyClass f1, ref int f2)
    //     {
    //         f1.Val = f1.Val + 5;
    //         f2 = f2 + 5;
    //         Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
    //     }

    //     static void Main()
    //     {
    //         MyClass a1 = new MyClass();
    //         int a2 = 10;

    //         MyMethod(ref a1, ref a2);
    //         Console.WriteLine("f1.Val: {0}, f2: {2}", a1.Val, a2);
    //     }
    // }

    /* class MyClass { public int Val = 20; }

    class Program 
    {
        static void RefAsParameter(MyClass f1)
        {
            f1.Val = 50;

            Console.WriteLine("After member assignment: {0}", f1.Val);
            f1 = new MyClass();

            Console.WriteLine("After new object creation: {0}", f1.Val);
        }

        static void Main()
        {
            MyClass a1 = new MyClass();

            Console.WriteLine("Before method call: {0}", a1.Val);
            RefAsParameter(a1);
            Console.WriteLine("After method call: {0}", a1.Val);
        }
    } */

    // class MyClass
    // {
    //     public int Val = 20;
    // }

    // class Program
    // {
    //     static void RefAsParameter(ref MyClass f1)
    //     {
    //         f1.Val = 50;
    //         Console.WriteLine("After member assignment: {0}", f1.Val);

    //         f1 = new MyClass();
    //         Console.WriteLine("After new object creation: {0}", f1.Val);
    //     }

    //     static void Main(string[] args)
    //     {
    //         MyClass a1 = new MyClass();

    //         Console.WriteLine("Before method call: {0}", a1.Val);
    //         RefAsParameter(ref a1);
    //         Console.WriteLine("After method call: {0}", a1.Val);
    //     }
    // }

    /* class MyClass 
    {
        public int Val = 20;
    }

    class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();
            f1.Val = 25;
            f2 = 15;
        }

        static void Main()
        {
            MyClass a1 = null;
            int a2;

            MyMethod(out a1, out a2);
        }
    } */

    // class MyClass
    // {
    //     public void ListInts(params int[] inVals)
    //     {
    //         if ((inVals != null) && (inVals.Length != 0))
    //             for (int i = 0; i < inVals.Length; i++)
    //             {
    //                 inVals[i] = inVals[i] * 10;
    //                 Console.WriteLine("{0}", inVals[i]);
    //             }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         int first = 5, second = 6, third = 7;

    //         MyClass mc = new MyClass();
    //         mc.ListInts(first, second, third);

    //         Console.WriteLine("{0}, {1}, {2}", first, second, third);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         int[] myArr = new int[] { 5, 6, 7 };

    //         MyClass mc = new MyClass();
    //         mc.ListInts(myArr);

    //         foreach (int x in myArr)
    //         {
    //             Console.WriteLine("{0}", x);
    //         }
    //     }
    // }

    // class MyClass 
    // {
    //     public int Calc(int a, int b, int c)
    //     { return (a + b) * c;}

    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();
    //         // int result = mc.Calc(c: 2, a: 4, b: 3);

    //         // Console.WriteLine("{0}", result);

    //         int r0 = mc.Calc(4, 3, 2);
    //         int r1 = mc.Calc(4, b: 3, c: 2);
    //         int r2 = mc.Calc(4, c: 2, b: 3);
    //         int r3 = mc.Calc(c: 2, b: 3, a: 4);
    //         int r4 = mc.Calc(c: 2, b:1 + 2, a: 3 + 1);

    //         Console.WriteLine("{0}, {1}, {2}, {3}, {4}", r0, r1, r2, r3, r4);
    //     }
    // }
    
    
    // class MyClass
    // {
    //     double GetCylinderVolume(double radius, double height)
    //     {
    //         return 3.1416 * radius * radius * height;
    //     }

    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();
    //         double volume;

    //         volume = mc.GetCylinderVolume(3.0, 4.0);
    //         volume = mc.GetCylinderVolume(radius: 3.0, height: 4.0);
    //     }
    // }


    // class MyClass
    // {
    //     public int Calc(int a, int b = 3)
    //     {
    //         return a + b;
    //     }

    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();

    //         int r0 = mc.Calc(5, 6);
    //         int r1 = mc.Calc(5);

    //         Console.WriteLine("{0}, {1}", r0, r1);
    //     }
    // }

    // class MyClass
    // {
    //     public int Calc(int a = 2, int b = 3, int c = 4)
    //     {
    //         return (a + b) * c;
    //     }

    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();
    //         int r0 = mc.Calc(5, 6, 7);
    //         int r1 = mc.Calc(5, 6);
    //         int r2 = mc.Calc(5);
    //         int r3 = mc.Calc();

    //         Console.WriteLine("{0}, {1}, {2}, {3}", r0, r1, r2, r3);
    //     }
    // }

    // class MyClass
    // {
    //     double GetCylinderVolume(double radius = 3.0, double height = 4.0)
    //     {
    //         return 3.1416 * radius * radius * height;
    //     }

    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();
    //         double volume;

    //         volume = mc.GetCylinderVolume(3.0, 4.0);
    //         Console.WriteLine("Volume = " + volume);

    //         volume = mc.GetCylinderVolume(radius: 2.0);
    //         Console.WriteLine("Volume = " + volume);

    //         volume = mc.GetCylinderVolume(height: 2.0);
    //         Console.WriteLine("Volume = " + volume);

    //         volume = mc.GetCylinderVolume();
    //         Console.WriteLine("Volume = " + volume);
    //     }
    // }

    // class Program
    // {
    //     static void MethodA(int par1, int par2)
    //     {
    //         Console.WriteLine("Enter MethodA: {0}, {1}", par1, par2);
    //         methodB(11, 18);
    //         Console.WriteLine("Exit MethodA");
    //     }

    //     static void MethodB(int par1, int par2)
    //     {
    //         Console.WriteLine("Enter MethodB: {0}, {1}", par1, par2);
    //         Console.WriteLine("Exit MethodB");
    //     }

    //     static void Main()
    //     {
    //         Console.WriteLine("Enter Main");
    //         methodA(15, 30);
    //         Console.WriteLine("Exit Main");
    //     }
    // }

    class Program
    {
        int Factorial(int inValue)
        {
            if (inValue <= 1)
                return inValue;
            else
                return inValue * Factorial(inValue - 1);
        }

        public void Count(int inVal)
        {
            if (inVal == 0)
                return;
            Count(inVal - 1);

            Console.WriteLine("{0}", inVal);
        }

        static void Main()
        {
            Program pr = new Program();
            pr.Count(3);
        }
    }
}