using System;

namespace Demo
{
    // class SomeClass
    // {
    //     public string Field1 = "base calss field";
    //     public void Method1(string value)
    //     {
    //         Console.WriteLine("Base class -- Method1: {0}", value);
    //     }
    // }

    // class OtherClass : SomeClass
    // {
    //     public string Field2 = "derived class field";

    //     new public string Field1;   // 用同样的名称屏蔽基类成员
    //     public void Method2(string value)
    //     {
    //         Console.WriteLine("Derived class -- Method2: {0}", value);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         OtherClass oc = new OtherClass();

    //         oc.Method1(oc.Field1);
    //         oc.Method1(oc.Field2);
    //         oc.Method2(oc.Field1);
    //         oc.Method2(oc.Field2);
    //     }
    // }

    // class SomeClass
    // {
    //     public string Field1 = "SomeClass Field1";
    //     public void Method1(string value)
    //     {
    //         Console.WriteLine("SomeClass.Method1: {0}", value);
    //     }
    // }

    // class OtherClass : SomeClass
    // {
    //     new public string Field1 = "OtherClass Field";
    //     new public void Method1(string value)
    //     {
    //         Console.WriteLine("OtherClass.Method1: {0}", value);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         OtherClass oc = new OtherClass();
    //         oc.Method1(oc.Field1);
    //     }
    // }

    // class SomeClass
    // {
    //     public string Field1 = "Field1 -- In the base class";
    // }

    // class OtherClass : SomeClass
    // {
    //     new public string Field1 = "Field -- In the derived class";

    //     public void PrintField1()
    //     {
    //         Console.WriteLine(Field1);
    //         Console.WriteLine(base.Field1);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         OtherClass oc = new OtherClass();
    //         oc.PrintField1();
    //     }
    // }

    // class MyBaseClass
    // {
    //     public void Print()
    //     {
    //         Console.WriteLine("This is the base class.");
    //     }
    // }

    // class MyDerivedClass : MyBaseClass
    // {
    //     new public void Print()
    //     {
    //         Console.WriteLine("This is the derived class.");
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyDerivedClass derived = new MyDerivedClass();
    //         MyBaseClass mybc = (MyBaseClass)derived;

    //         derived.Print();
    //         mybc.Print();
    //     }
    // }

    // class MyBaseClass
    // {
    //     virtual public void Print()
    //     {
    //         Console.WriteLine("This is the base class.");
    //     }
    // }

    // class MyDerivedClass : MyBaseClass
    // {
    //     override public void Print()
    //     {
    //         Console.WriteLine("This is the derived class.");
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyDerivedClass dervied = new MyDerivedClass();
    //         MyBaseClass mybc = (MyBaseClass)dervied;

    //         dervied.Print();
    //         mybc.Print();

    //     }
    // }

    // class MyBaseClass
    // {
    //     virtual public void Print()
    //     {
    //         Console.WriteLine("This is the base class.");
    //     }
    // }

    // class MyDerivedClass : MyBaseClass
    // {
    //     override public void Print()
    //     {
    //         Console.WriteLine("This is the derived class.");
    //     }
    // }

    // class SecondDerived : MyDerivedClass
    // {
    //     //public override void Print()
    //     new public void Print()
    //     {
    //         Console.WriteLine("This is the second derived class.");
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         SecondDerived derived = new SecondDerived();
    //         MyBaseClass mybc = (MyBaseClass)derived;

    //         derived.Print();
    //         mybc.Print();
    //     }
    // }

    // class MyBaseClass
    // {
    //     private int _myInt = 5;
    //     virtual public int MyProperty
    //     {
    //         get { return _myInt; }
    //     }
    // }

    // class MyDerivedClass : MyBaseClass
    // {
    //     private int _myInt = 10;
    //     public override int MyProperty
    //     {
    //         get { return _myInt; }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyDerivedClass derived = new MyDerivedClass();
    //         MyBaseClass mybc = (MyBaseClass)derived;

    //         Console.WriteLine(derived.MyProperty);
    //         Console.WriteLine(mybc.MyProperty);
    //     }
    // }

    // class MyClass
    // {
    //     readonly int firstVar;
    //     readonly double secondVar;

    //     public string UserName;
    //     public int UserIdNumber;

    //     private MyClass()
    //     {
    //         firstVar = 20;
    //         secondVar = 30.5;
    //     }

    //     public MyClass(string firstName) : this()
    //     {
    //         UserName = firstName;
    //         UserIdNumber = -1;
    //     }

    //     public MyClass(int idNumber) : this()
    //     {
    //         UserName = "Anonymous";
    //         UserIdNumber = idNumber;
    //     }
    // }

    // abstract class AbClass
    // {
    //     public void IdentifyBase()
    //     {
    //         Console.WriteLine("I am AbClass");
    //     }

    //     abstract public void IdentifyDerived();
    // }

    // class DerivedClass : AbClass
    // {
    //     public override void IdentifyDerived()
    //     {
    //         Console.WriteLine("I am DerivedClass");
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         // AbClass a = new AbClass();   // error抽象类不能实例化
    //         // a.IdentifyBase();

    //         DerivedClass b = new DerivedClass();
    //         b.IdentifyBase();
    //         b.IdentifyDerived();

    //     }
    // }

    // abstract class MyBase
    // {
    //     public int SideLength = 10;
    //     const int TriangleSideCount = 3;

    //     abstract public void PrintStuff(string s);
    //     abstract public int MyInt { get; set; }

    //     public int PerimeterLength()
    //     {
    //         return TriangleSideCount * SideLength;
    //     }
    // }

    // class MyClass : MyBase
    // {
    //     public override void PrintStuff(string s)
    //     {
    //         Console.WriteLine(s);
    //     }
    //     private int _myInt;

    //     public override int MyInt
    //     {
    //         get { return _myInt; }
    //         set { _myInt = value; }
    //     }
    // }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         MyClass mc = new MyClass();
    //         mc.PrintStuff("This is a string.");
    //         mc.MyInt = 28;
    //         Console.WriteLine(mc.MyInt);
    //         Console.WriteLine("Perimeter Length: {0}", mc.PerimeterLength());
    //     }
    // }

    // static public class MyMath
    // {
    //     public static float PI = 3.14f;
    //     public static bool IsOdd(int x) { return x % 2 == 1; }
    //     public static int Times2(int x) { return x * x; }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         int val = 3;
    //         Console.WriteLine("{0} is odd is {1}.", val, MyMath.IsOdd(val));
    //         Console.WriteLine("{0} * 2 = {1}.", val, MyMath.Times2(val));
    //     }
    // }

    // class MyData
    // {
    //     private double D1;
    //     private double D2;
    //     private double D3;

    //     public MyData(double d1, double d2, double d3)
    //     {
    //         D1 = d1; D2 = d2; D3 = d3;
    //     }

    //     public double Sum()
    //     {
    //         return D1 + D2 + D3;
    //     }
    // }

    // static class ExtendMyData
    // {
    //     public static double Average(this MyData md)
    //     {
    //         return md.Sum() / 3;
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyData md = new MyData(3, 4, 5);
    //         Console.WriteLine("Average: {0}", ExtendMyData.Average(md));

    //         ExtendMyData.Average(md);
    //         md.Average();

    //   }
    // }
}

namespace ExtensionMethods
{
    sealed class MyData
    {
        private double D1, D2, D3;
        public MyData(double d1, double d2, double d3)
        { D1 = d1; D2 = d2; D3 = d3; }

        public double Sum() { return D1 + D2 + D3; }
    }

    static class ExtendMyData
    {
        public static double Average(this MyData md)
        { return md.Sum() / 3; }
    }

    class Program
    {
        static void Main()
        {
            MyData md = new MyData(3, 4, 5);
            Console.WriteLine("Sum: {0}", md.Sum());
            Console.WriteLine("Average: {0}", md.Average());
        }
    }
}