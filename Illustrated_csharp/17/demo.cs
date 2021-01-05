using System;

// class SomeClass<T1, T2>
// {
//     T1 SomeVar;
//     T2 OtherVar;
// }

// class Program
// {
//     static void Main()
//     {
//         var first = new SomeClass<short, int>();
//         var second = new SomeClass<int, long>();
//     }
// }


// class MyStack<T>
// {
//     T[] StackArray;
//     int StackPointer = 0;
//     public void Push(T x)
//     {
//         if (!IsStackFull)
//             StackArray[StackPointer++] = x;
//     }

//     public T Pop()
//     {
//         return (!IsStackEmpty) ? StackArray[--StackPointer] : StackArray[0];
//     }

//     const int MaxStack = 10;
//     bool IsStackFull{get { return StackPointer >= MaxStack; } }
//     bool IsStackEmpty{get { return StackPointer <= 0; } }

//     public MyStack()
//     {
//         StackArray = new T[MaxStack];
//     }

//     public void Print()
//     {
//         for (int i = StackPointer - 1; i >= 0; i--)
//             Console.WriteLine(" Value: {0}", StackArray[i]);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyStack<int> StackInt = new MyStack<int>();
//         MyStack<string> StackString = new MyStack<string>();

//         StackInt.Push(3);
//         StackInt.Push(5);
//         StackInt.Push(7);
//         StackInt.Push(9);
//         StackInt.Push();

//         StackString.Push("This is fun");
//         StackString.Push("Hi there!");
//         StackString.Print();
//     }
// }


// class Simple
// {
//     static public void ReverseAndPrint<T>(T[] arr)
//     {
//         Array.Reverse(arr);
//         foreach(T item in arr)
//             Console.Write("{0}, ", item.ToString());
//         Console.WriteLine("");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var intArray = new int[] { 3, 5, 6, 9, 11 };
//         var stringArray = new string[] { "first", "second", "third" };
//         var doubleArray = new double[] { 3.567, 7.891, 2.345 };

//         Simple.ReverseAndPrint<int>(intArray);
//         Simple.ReverseAndPrint(intArray);

//         Simple.ReverseAndPrint<string>(stringArray);
//         Simple.ReverseAndPrint(stringArray);

//         Simple.ReverseAndPrint<double>(doubleArray);
//         Simple.ReverseAndPrint(doubleArray);
//     }
// }


// static class ExtendHolder
// {
//     public static void Print<T>(this ExtendHolder<T> h)
//     {
//         T[] vals = h.GetValues();
//         Console.WriteLine("{0},\t{1},\t{2}", vals[0], vals[1], vals[2]);
//     }
// }

// class Holder<T>
// {
//     T[] Vals = new T[3];

//     public Holder(T v0, T v1, T v2)
//     { Vals[0] = v0; vals[1] = v1; Vals[2] = v2; }

//     public T[] GetValues() { return Vals; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         var intHolder = new Holder<int>(3, 5, 7);
//         var stringHolder = new Holder<string>("a1", "b2", "c3");
//         intHolder.Print();
//         stringHolder.Print();
//     }
// }


// struct PieceOfData<T>
// {
//     public PieceOfData(T value) { _data = value; }
//     private T _data;
//     public T Data
//     {
//         get { return _data; }
//         set { _data = value; }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var intData = new PieceOfData<int>(10);
//         var stringData = new PieceOfData<string>("Hi there.");

//         Console.WriteLine("intData = {0}", intData.Data);
//         Console.WriteLine("stringData = {0}", stringData.Data);
//     }
// }


// delegate void MyDelegate<T>(T value);

// class Simple
// {
//     static public void PrintString(string s)
//     {
//         Console.WriteLine(s);
//     }

//     static public void PrintUpperSrting(string s)
//     {
//         Console.WriteLine("{0}", s.ToUpper());
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var myDel = new MyDelegate<string>(Simple.PrintString);
//         myDel += Simple.PrintUpperSrting;

//         myDel("Hi There.");
//     }
// }


// public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);

// class Simple
// {
//     static public string PrintString(int p1, int p2)
//     {
//         int total = p1 + p2;
//         return total.ToString();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var myDel = new Func<int, int, string>(Simple.PrintString);

//         Console.WriteLine.Equals("Total: {0}", myDel(15, 13));
//     }
// }


// interface IMyIfc<T>
// {
//     T ReturnIt(T inValue);
// }

// class Simple<S> : IMyIfc<S>
// {
//     public S ReturnIt(S inValue)
//     { return inValue; }
// }

// class Program
// {
//     static void Main()
//     {
//         var trivInt = new Simple<int>();
//         var trivString = new Simple<string>();

//         Console.WriteLine("{0}", trivInt.ReturnIt(5));
//         Console.WriteLine("{0}", trivString.ReturnIt("Hi ther."));
//     }
// }


// interface IMyIfc<T>
// {
//     T ReturnIt(T inValue);
// }

// class Simple : IMyIfc<int>, IMyIfc<string>
// {
//     public int ReturnIt(int inValue)
//     { return inValue; }

//     public string ReturnIt(string inValue)
//     { return inValue; }
// }

// class Program
// {
//     static void Main()
//     {
//         Simple trivial = new Simple();

//         Console.WriteLine("{0}", trivial.ReturnIt(5));
//         Console.WriteLine("{0}", trivial.ReturnIt("Hi there."));
//     }
// }


// interface IMyIfc<T>
// {
//     T ReturnIt(T inValue);
// }

// class Simple<S> : IMyIfc<int>, IMyIfc<S>        //error
// {
//     public int ReturnIt(int inValue)
//     {
//         return inValue;
//     }

//     public S ReturnIt(S inValue)
//     {
//         return inValue;
//     }
// }


// class Animal
// {
//     public int NumberOfLegs = 4;
// }

// class Dog : Animal { }

// class Program
// {
//     static void Main()
//     {
//         Animal a1 = new Animal();
//         Animal a2 = new Dog();

//         Console.WriteLine("Number of dog legs: {0}", a2.NumberOfLegs);
//     }
// }



// class Animal { public int Legs = 4; }
// class Dog : Animal { }

// delegate T Factory<out T>();

// class Program
// {
//     static Dog MakeDog()
//     {
//         return new Dog();
//     }

//     static void Main()
//     {
//         Factory<Dog> dogMaker = MakeDog;
//         Factory<Animal> animalMaker = dogMaker;

//         Console.WriteLine(animalMaker().Legs.ToString());
//     }
// }


// class Animal { public int NuimberOfLegs = 4; }
// class Dog : Animal { }

// class Progarm
// {
//     delegate void Action1<in T>(T a);

//     static void ActOnAnimal(Animal a)
//     {
//         Console.WriteLine(a.NuimberOfLegs);
//     }

//     static void Main()
//     {
//         Action1<Anumal> act1 = ActOnAnimal;
//         Action1<Dog> dog1 = act1;
//         dog1(new Dog());
//     }
// }


// class Animal { public string Name; }
// class Dog : Animal { };

// interface IMyIfc<out T>
// {
//     T GetFirst();
// }

// class SimpleReturn<T> : IMyIfc<T>
// {
//     public T[] items = new T[2];
//     public T GetFirst() { return items[0]; }
// }

// class Program
// {
//     static void DoSomething(IMyIfc<Animal> returner)
//     {
//         Console.WriteLine(returner.GetFirst().Name);
//     }

//     static void Main()
//     {
//         SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog>();
//         dogReturner.items[0] = new Dog() { Name = "Avonlea" };

//         IMyIfc<Animal> animalReturner = dogReturner;

//         DoSomething(dogReturner);
//     }
// }

class Animal { public int Legs = 4; }
class Dog : Animal { }

class Program
{
    delegate T Factory<out T>();
    static Dog MakeDog() { return new Dog(); }

    static void Main()
    {
        Factory<Animal> animalMaker1 = MakeDog;

        Factory<Dog> dogMaker = MakeDog;
        Factory<Animal> animalMaker2 = dogMaker;

        Factory<Animal> animalMaker3 = new Factory<Dog>(MakeDog);
    }
}