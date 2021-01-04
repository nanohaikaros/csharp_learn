using System;

// class CA
// {
//     public string Name;
//     public string Age;
// }

// class CB
// {
//     public string First;
//     public string Last;
//     public double PersonsAge;
// }

// class program
// {
//     static void PrintInfo(CA item)
//     {
//         Console.WriteLine("Name: {0}, Age {1}", item.Name, item.Age);
//     }

//     static void Main()
//     {
//         CA a = new CA() { Name = "John Doe", Age = 35 };
//         PrintInfo(a);
//     }
// }

// interface IInfo
// {
//     string GetName();
//     string GetAge();
// }

// class CA : IInfo
// {
//     public string Name;
//     public int Age;
//     public string GetName() { return Name; }
//     public string GetAge() { return Age.ToString(); }
// }

// class CB : IInfo
// {
//     public string First;
//     public string Last;
//     public double PersonsAge;
//     public string GetName() { return First + " " + Last; }
//     public string GetAge() { return PersonsAge.ToString(); }
// }

// class Program
// {
//     static void PrintInfo(IInfo item)
//     {
//         Console.WriteLine("Name: {0}, Age {1}", item.GetName(), item.GetAge());
//     }

//     static void Main()
//     {
//         CA a = new CA() { name = "John Doe", Age = 35 };
//         CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };

//         PrintInfo(a);
//         PrintInfo(b);

//         var myInt = new[] { 20, 4, 16, 9, 2 };
//         Array.Sort(myInt);
//         foreach(var i in myInt)
//             Console.WriteLine("{0} ", i);
//     }
// }


// class MyClass : IComparable
// {
//     public int TheValue;

//     public int CompaerTo(object obj)
//     {
//         MyClass mc = (MyClass)obj;
//         if (this.TheValue < mc.TheValue) return -1;
//         if (this.TheValue > mc.TheValue) return 1;
//         return 0;
//     }
// }

// class MyClass : IComparable
// {
//     public int TheValue;
//     public int CompaerTo(object obj)
//     {
//         MyClass mc = (MyClass)obj;
//         if (this.TheValue < mc.TheValue) return -1;
//         if (this.TheValue > mc.TheValue) return 1;
//         return 0;
//     }
// }

// class Program
// {
//     static void PrintOut(string s, MyClass[] mc)
//     {
//         Console.Write(s);
//         foreach (var m in mc)
//             Console.Write("{0} ", m.TheValue);
//         Console.WriteLine("");
//     }

//     static void Main()
//     {
//         var myInt = new[] { 20, 4, 16, 9, 2 };
//         MyClass[] mcArr = new MyClass[5];
//         for (int i = 0; i < 5; i++)
//         {
//             mcArr[i] = new MyClass();
//             mcArr[i].TheValue = myInt[i];
//         }
//         PrintOut("Initial Order: ", mcArr);
//         Array.Sort(mcArr);
//         PrintOut("Sorted Order: ", mcArr);
//     }
// }

// interface IMyInterface1
// {
//     int DoStuff(int nVar1, long lVar2);
//     double DoOtherStuff(string s, long x);
// }


// public interface IMyInterface2
// {
//     private int Method1(int nVar1, long lVar2);     //error
// }

// interface IIfc1
// {
//     void PrintOut(string s);
// }

// class MyClass : IIfc1
// {
//     public void PrintOut(string s)
//     {
//         Console.WriteLine("Calling through: {0}", s);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();
//         mc.PrintOut("object");
//     }
// }

// interface IIfc1
// {
//     void PrintOut(string s);
// }

// class MyClass : IIfc1
// {
//     public void PrintOut(string s)
//     {
//         Console.WriteLine("Calling through: {0}", s);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();
//         mc.PrintOut("object");

//         IIfc1 ifc = (IIfc1)mc;
//         ifc.PrintOut("interface");
//     }
// }

// interface IDataRetrieve { int GetData(); }
// interface IDataStore { void SetData(int x); }

// class MyData : IDataRetrieve, IDataStore
// {
//     int Mem1;
//     public int GetData() { return Mem1; }
//     public void SetData(int x) { Mem1 = x; }
// }

// class Program
// {
//     static void Main()
//     {
//         MyatDa data = new MyData();
//         data.SetData(5);
//         Console.WriteLine("Value = {0}", data.GetData);
//     }
// }


// interface IIfc1
// {
//     void PrintOut(string s);
// }

// interface IIfc2
// {
//     void PrintOut(string t);
// }

// class MyClass : IIfc1, IIfc2
// {
//     public void PrintOut(string s)
//     {
//         Console.WriteLine("Calling through: {0}", s);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();
//         mc.PrintOut("object");
//     }
// }

// interface IIfc1
// {
//     void PrintOut(string s);
// }

// interface IIfc2
// {
//     void PrintOut(string s);
// }

// class MyClass : IIfc1, IIfc2
// {
//     public void PrintOut(string s)
//     {
//         Console.WriteLine("Calling through: {0}", s);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();

//         IIfc1 ifc1 = (IIfc1)mc;
//         IIfc2 ifc2 = (IIfc2)mc;

//         mc.PrintOut("object");

//         ifc1.PrintOut("interface 1");
//         ifc2.PrintOut("interface 2");
//     }
// }

// interface IIfc1 { void PrintOut(string s); }

// class MyBaseClass
// {
//     public void PrintOut(string s)
//     {
//         Console.WriteLine("Calling through: {0}", s);
//     }
// }

// class Derived : MyBaseClass, IIfc1 { }

// class Program
// {
//     static void Main()
//     {
//         Derived d = new Derived();
//         d.PrintOut("object.");
//     }

// }


// interface IIfc1 { void PrintOut(string s); }
// interface IIfc2 { void PrintOut(string t); }

// class MyClass : IIfc1, IIfc2
// {
//     void IIfc1.PrintOut(string s)
//     {
//         Console.WriteLine("IIfc1: {0}", s);
//     }

//     void IIfc2.PrintOut(string t)
//     {
//         Console.WriteLine("IIfc2: {0}", s);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();

//         IIfc1 ifc1 = (IIfc1)mc;
//         ifc1.PrintOut("interface 1");

//         IIfc2 ifc2 = (IIfc2)mc;
//         ifc2.PrintOut("interface 2");
//     }
// }



// interface IDataRetrieve { int GetData(); }
// interface IDataStore { void SetData(int x); }

// interface IDataIO : IDataRetrieve, IDataStore { }

// class MYData : IDataIO
// {
//     int nPrivateData;
//     public int GetData() { return nPrivateData; }
//     public void SetData(int x) { nPrivateData = x; }
// }

// class Progarm
// {
//     static void Main()
//     {
//         MYData data = new MYData();
//         data.SetData(5);
//         Console.WriteLine("{0}", data.GetData());
//     }
// }

interface ILiveBirth
{
    string BabyCalled();
}

class Animal { }

class Cat : Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "kitten";
    }
}

class Dog : Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "puppy";
    }
}

class Bird : Animal {}

class Program
{
    static void Main()
    {
        Animal[] animalArray = new Animal[3];
        animalArray[0] = new Cat();
        animalArray[1] = new Bird();
        animalArray[2] = new Dog();
        foreach(Animal a in animalArray)
        {
            ILiveBirth b = a as ILiveBirth;
            if (b != null)
                Console.WriteLine("Baby is called: {0}", b.BabyCalled());
        }
    }
}