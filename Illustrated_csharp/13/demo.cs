using System;

// delegate void MyDel(int value);

// class Program
// {
//     void PrintLow(int value)
//     {
//         Console.WriteLine("{0} - Low Value", value);
//     }

//     void PrintHigh(int value)
//     {
//         Console.WriteLine("{0} - High Value", value);
//     }

//     static void Main()
//     {
//         Program program = new Program();

//         MyDel del;

//         Random rand = new Random();
//         int randomValue = rand.Next(99);

//         del = randomValue < 50 ? new MyDel(program.PrintLow) : new MyDel(program.PrintHigh);

//         del(randomValue);
//     }
// }

// delegate void PrintFunction();

// class Test
// {
//     public void Print1()
//     {
//         Console.WriteLine("Print1 -- instance");
//     }

//     public static void Print2()
//     {
//         Console.WriteLine("Print2 -- static");
//     }

//     static void Main()
//     {
//         Test t = new Test();
//         PrintFunction pf;

//         pf = t.Print1;

//         pf += Test.Print2;
//         pf += t.Print1;
//         pf += Test.Print2;

//         if (null != pf)
//             pf();
//         else
//             Console.WriteLine("Delegate is empty");

//     }
// }


// delegate int MyDel();
// class MyClass
// {
//     int IntValue = 5;
//     public int Add2() { IntValue += 2; return IntValue; }
//     public int Add3() { IntValue += 3; return IntValue; }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();
//         MyDel mDel = mc.Add2;
//         mDel += mc.Add3;
//         mDel += mc.Add2;

//         Console.WriteLine("Value: {0}", mDel());
//     }
// }


// delegate void MyDel(ref int X);

// class MyClass
// {
//     public void Add2(ref int x) { x += 2; }
//     public void Add3(ref int x) { x += 3; }
//     static void Main()
//     {
//         MyClass mc = new MyClass();

//         MyDel mDel = mc.Add2;
//         mDel += mc.Add3;
//         mDel += mc.Add2;

//         int x = 5;
//         mDel(ref x);

//         Console.WriteLine("Value: {0}", x);
//     }
// }


delegate double MyDel(int par);

class Program
{
    static void Main()
    {
        MyDel del = delegate (int x) { return x + 1; }; //匿名方法

        MyDel le1 = (int x) => { return x + 1; };   //Lambda表达式
        MyDel le2 = (x) => { return x + 1; };
        MyDel le3 = x => { return x + 1; };
        MyDel le4 = x => x + 1;

        Console.WriteLine("{0}", del(12));
        Console.WriteLine("{0}", le1(12));
        Console.WriteLine("{0}", le2(12));
        Console.WriteLine("{0}", le3(12));
        Console.WriteLine("{0}", le4(12));
    }
}