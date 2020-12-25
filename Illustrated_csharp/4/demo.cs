using System;

namespace Demo
{
    class MyClass
    {
        int F1;     // 初始化为0
        string F2;  // 初始化为null

        int F3 = 25;    // 初始化为25

        string F4 = "abcd";     // 初始化为“abcd”
    }

    class SimpleClass
    {
        void PrintNums()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
        }
    }

    class Dealer { }

    /* class App
    {
        static void Main()
        {
            Dealer theDealer;
            theDealer = new Dealer();

            // Dealer theDealer = new Dealer();
        }
    } */

    class Player
    {
        string Name;
    }

    class Program
    {
        static void Main()
        {
            Dealer theDealer = new Dealer();
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
        }
    }

    class C1
    {
        int F1;     // 隐式私有字段
        private int F2;     // 显式私有字段

        public int F3;      // 公有字段

        void DoCalc() { }   // 隐式私有方法

        public int GetVal() { } // 公有方法
    }

    /* class DaysTemp
    {
        // 字段
        private int High = 75;
        private int Low = 45;

        // 方法
        private int GetHigh()
        {
            return High;    // 访问私有字段
        }

        private int GetLow()
        {
            return Low;     // 访问私有字段
        }

        public float Average()
        {
            return (GetHigh() + GetLow()) / 2;      // 访问私有方法
        }
    }

    class Program
    {
        static void Main()
        {
            DaysTemp myDt = new DaysTemp(); // 创建类的对象
            float fValue = myDt.Average();  // 从外部访问
        }
        
    } */

    /* class DaysTemp              // 声明类DaysTemp
    {
        public int High = 75;
        public int Low = 35;
    }

    class Program           // 声明类Program
    {
        static void Main()
        {
            DaysTemp temp = new DaysTemp();         // 创建对象

            temp.High = 85;     // 字段赋值
            temp.Low = 60;

            Console.WriteLine("High:   {0}", temp.High);    // 读取字段值
            Console.WriteLine("Low:    {0}", temp.Low);
        }
    } */

    class DaysTemp          // 声明类
    {
        public int High, Low;   // 声明实例字段
        public int Average()    // 声明实例方法
        {
            return (High + Low) / 2;
        }
    }

    class Program
    {
        static void Main()
        {
            // 创建两个DaysTemp实例
            DaysTemp t1 = new DaysTemp();
            DaysTemp t2 = new DaysTemp();

            // 给字段赋值
            t1.High = 76; t1.Low = 57;
            t2.High = 75; t2.Low = 53;

            // 读取字段值
            // 调用实例的方法
            Console.WriteLine("t1: {0}, {1}, {2}", t1.High, t1.Low, t1.Average());
            Console.WriteLine("t2: {0}, {1}, {2}", t2.High, t2.Low, t2.Average());
        }
    }
}