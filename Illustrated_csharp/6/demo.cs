using System;

namespace Demo
{
    /* class D
    {
        public int Mem1;
        static int Mem2;

        public void SetVars(int v1, int v2)
        { Mem1 = v1; Mem2 = v2; }

        public void Display(string str)
        { Console.WriteLine("{0}: Mem1 = {1}, Mem2 = {2}", str, Mem1, Mem2); }
    }

    class Program
    {
        static void Main()
        {
            D d1 = new D();
            D d2 = new D();
            // d1.Mem1 = 10; d2.Mem1 = 28;

            // Console.WriteLine("d1 = {0}, d2 = {1}", d1.Mem1, d2.Mem1);

            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(15, 17);
            d2.Display("d2");

            d1.Display("d1");
        }
    } */

    // class D
    // {
    //     int Mem1;
    //     static public int Mem2;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         D.Mem2 = 5;
    //         Console.WriteLine("Mem2 = {0}", D.Mem2);
    //     }
    // }

    // class X
    // {
    //     static public int A;
    //     static public void PrintValA()
    //     {
    //         Console.WriteLine("Value of A: {0}", A);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         X.A = 10;
    //         X.PrintValA();
    //     }
    // }

    // class X
    // {
    //     public const double PI = 3.1416;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Console.WriteLine("pi = {0}", X.PI);
    //     }
    // }

    // class C1
    // {
    //     private int TheRealValue;

    //     public int MyValue
    //     {
    //         set
    //         {
    //             TheRealValue = value;
    //         }

    //         get
    //         {
    //             return TheRealValue;
    //         }
    //     }
    // }

    // class C1
    // {
    //     private int TheRealValue = 10;
    //     public int MyValue
    //     {
    //         // set { TheRealValue = value; }
    //         // get { return TheRealValue; }

    //         set
    //         {
    //             TheRealValue = value > 100 ? 100 : value;
    //         }
    //         set { return TheRealValue; }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         C1 c = new C1();
    //         Console.WriteLine("MyValue: {0}", c.MyValue);

    //         c.MyValue = 20;
    //         Console.WriteLine("MyValue: {0}", c.MyValue);
    //     }
    // }

    // class RightTriangle
    // {
    //     public double A = 3;
    //     public double B = 4;
    //     public douuble Hypotenuse
    //     {
    //         get { return Math.Sqrt((A * A) + (B * B)); }
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         RightTriangle c = new RightTriangle();
    //         Console.WriteLine("Hypotenuse: {0}", c.Hypotenuse);
    //     }
    // }

    // class C1
    // {
    //     public int MyValue
    //     {
    //         set; get;
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         C1 c = new C1();
    //         Console.WriteLine("MyValue: {0}", c.MyValue);

    //         c.MyValue = 20;
    //         Console.WriteLine("MyValue: {0}", c.MyValue);
    //     }
    // }

    // class Trivial
    // {
    //     public static int MyValue{ get; set; }
    //     public void PrintValue()
    //     {
    //         Console.WriteLine("Value from inside: {0}", MyValue);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Console.WriteLine("Init Value: {0}", Trivial.MyValue);
    //         Trivial.MyValue = 10;
    //         Console.WriteLine("New Value: {0}", Trivial.MyValue);
    //         Trivial tr = new Trivial();
    //         tr.PrintValue();
    //     }
    // }

    // class Class1
    // {
    //     int Id;
    //     string Name;

    //     public Class1() { Id = 28; Name = "Nemo"; }
    //     public Class1(int val) { Id = val; Name = "Nemo"; }
    //     public Class1(string name) { Name = name; }

    //     public void SoundOff()
    //     {
    //         Console.WriteLine("Name {0}, Id {1}", Name, Id);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Class1 a = new Class1(), b = new Class1(7), c = new Class1("Bill");

    //         a.SoundOff();
    //         b.SoundOff();
    //         c.SoundOff();
    //     }
    // }

    // class RandomNumberClass
    // {
    //     private static Random RandomKey;

    //     static RandomNumberClass()
    //     {
    //         RandomKey = new Random();
    //     }

    //     public int GetRandomNumber()
    //     {
    //         return RandomKey.Next();
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         RandomNumberClass a = new RandomNumberClass();
    //         RandomNumberClass b = new RandomNumberClass();

    //         Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
    //         Console.WriteLine("Next Random #: {0}", b.GetRandomNumber());
    //     }
    // }

    // public class Point
    // {
    //     public int X = 1;
    //     public int Y = 2;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Point pt1 = new Point();
    //         Point pt2 = new Point { X = 5, Y = 6 };
    //         Console.WriteLine("pt1: {0}, {1}", pt1.X, pt1.Y);
    //         Console.WriteLine("pt2: {0}, {1}", pt2.X, pt2.Y);
    //     }
    // }

    // class Shape
    // {
    //     readonly double PI = 3.1416;
    //     readonly int NumberOfSides;

    //     public Shape(double side1, double side2)
    //     {
    //         NumberOfSides = 4;
    //     }

    //     public Shape(double side1, double side2, double side3)
    //     {
    //         NumberOfSides = 3;
    //     }
    // }

    // class MyClass
    // {
    //     int Var1 = 10;

    //     public int ReturnMaxSum(int Var1)
    //     {
    //         return Var1 > this.Var1 ? Var1 : this.Var1;
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();

    //         Console.WriteLine("Max: {0}", mc.ReturnMaxSum(30));
    //         Console.WriteLine("Max: {0}", mc.ReturnMaxSum(5));
    //     }
    // }

    // class Employee
    // {
    //     public string LastName;
    //     public string FirstName;
    //     public string CityOfBirth;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         Employee emp1 = new Employee();

    //         emp1.LastName = "Doe";
    //         emp1.FirstName = "Jane";
    //         emp1.CityOfBirth = "Dallas";
    //         Console.WriteLine("{0}", emp1.LastName);
    //         Console.WriteLine("{0}", emp1.FirstName);
    //         Console.WriteLine("{0}", emp1.CityOfBirth);

    //         emp1[0] = "Doe";
    //         emp1[1] = "Jane";
    //         emp1[2] = "Dallas";
    //         Console.WriteLine("{0}", emp1[0]);
    //         Console.WriteLine("{0}", emp1[1]);
    //         Console.WriteLine("{0}", emp1[2]);
    //     }
    // }

    // class Employee
    // {
    //     public string LastName;
    //     public string FirstName;
    //     public string CityOfBirth;

    //     public string this[int index]
    //     {
    //         set
    //         {
    //             switch (index)
    //             {
    //                 case 0: LastName = value;
    //                     break;
    //                 case 1: FirstName = value;
    //                     break;
    //                 case 2: CityOfBirth = value;
    //                     break;
    //                 default:
    //                     throw new ArgumentOutOfRangeException("index");
    //             }
    //         }

    //         get
    //         {
    //             switch (index)
    //             {
    //                 case 0: return LastName;
    //                 case 1: return FirstName;
    //                 case 2: return CityOfBirth;
    //                 default:
    //                     throw new ArgumentOutOfRangeException("index");
    //             }
    //         }
    //     }
    // }

    // class Class1
    // {
    //     int Temp0;
    //     int Temp1;
    //     public int this[int index]
    //     {
    //         get
    //         {
    //             return (0 == index) ? Temp0 : Temp1;
    //         }

    //         set
    //         {
    //             if (0 == index)
    //                 Temp0 = value;
    //             else
    //                 Temp1 = value;
    //         }
    //     }
    // }

    // class Example
    // {
    //     static void Main()
    //     {
    //         Class1 a = new Class1();

    //         Console.WriteLine("Values -- T0: {0}, T1: {1}", a[0], a[1]);
    //         a[0] = 15;
    //         a[1] = 20;
    //         Console.WriteLine("Value -- T0: {0}, T1: {1}", a[0], a[1]);
    //     }
    // }

    // class Person
    // {
    //     public string Name{ get; private set; }
    //     public Person(string name)
    //     {
    //         Name = name;
    //     }
    // }

    // class Program
    // {
    //     static public void Main()
    //     {
    //         Person p = new Person("Capt. Ernest Evans");
    //         Console.WriteLine("Person's name is {0}", p.Name);
    //     }
    // }

    partial class MyClass
    {
        partial void PrintSum(int x, int y);

        public void Add(int x, int y)
        {
            PrintSum(x, y);
        }
    }

    partial class MyClass
    {
        partial void PrintSum(int x, int y)
        {
            Console.WriteLine("Sum is {0}", x + y);
        }
    }

    class Program
    {
        static void Main()
        {
            var mc = new MyClass();
            mc.Add(5, 6);
        }
    }
}