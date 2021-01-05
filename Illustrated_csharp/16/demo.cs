using System;

// class MyClass
// {
//     static void Main()
//     {
// ushort sh = 10;
// byte sb = (byte)sh;
// Console.WriteLine("sb: {0} = 0x{0:X)", sb);

// sh = 1365;
// sb = (byte)sh;
// Console.WriteLine("sb: {0} = 0x{0:X}", sb);

// ushort sh = 2000;
// byte sb;

// sb = unchecked((byte)sh);
// Console.WriteLine("sb: {0}", sb);

// sb = checked((byte)sh);
// Console.WriteLine("sb: {0}", sb);    //error


// byte sb;
// ushort sh = 2000;

// unchecked
// {
//     sb = (byte)sh;
//     Console.WriteLine("sb: {0}", sb);

//     checked
//     {
//         sb = (byte)sh;
//         Console.WriteLine("sb: {0}", sh);    //error
//     }
// }
//     }
// }

// class A { public int Field1; }
// class B : A { public int Field2; }

// class Program
// {
// static void Main()
// {
//     // B myVar1 = new B();
//     // A myVar2 = (A)myVar1;

//     // Console.WriteLine("{0}", myVar2.Field1);
//     // Console.WriteLine("{0}", myVar2.Field2);    //error

//     // A myVar1 = new A();
//     // B myVar2 = (B)myVar1;

//     int i = 10;
//     object oi = i;
//     Console.WriteLine("i: {0}, io: {1}", i, oi);

//     i = 12;
//     oi = 15;
//     Console.WriteLine("i: {0}, io: {1}", i, oi);
// }

//     static void Main()
//     {
//         int i = 10;

//         object oi = i;

//         int j = (int)oi;
//         Console.WriteLine("i: {0}, oi: {1}, j: {2}", i, oi, j);
//     }
// }

// class Person
// {
//     public string Name;
//     public int Age;

//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

//     public static implicit operator int(Person p)
//     {
//         return p.Age;
//     }

//     public static implicit operator Person(int i)
//     {
//         return new Person("Nemo", i);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Person bill = new Person("bill", 25);

//         int age = bill;
//         Console.WriteLine("Person Info: {0}, {1}", bill.Name, age);

//         Person anon = 35;
//         Console.WriteLine("Person Info: {0}, {1}", anon.Name, anon.Age);
//     }
// }


// class Employee : Person { }

// class Person
// {
//     public string Name;
//     public int Age;

//     public static implicit operator int(Person p)
//     { return p.Age; }
// }

// class Program
// {
//     static void Main()
//     {
//         Employee bill = new Employee();
//         bill.Name = "William";
//         bill.Age = 25;

//         float fVar = bill;
//         Console.WriteLine("Person Info: {0}, {1}", bill.Name, fVar);
//     }
// }


// class Employee : Person { }
// class Person
// {
//     public string Name = "Anonymous";
//     public int Age = 25;
// }

// class Program
// {
//     static void Main()
//     {
//         Employee bill = new Employee();
//         Person p;

//         if (bill is Person)
//         {
//             p = bill;
//             Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
//         }
//     }
// }


class Employee : Person { }
class Person
{
    public string Name = "Anonymous";
    public int Age = 25;
}

class Program
{
    static void Main()
    {
        Employee bill = new Employee();
        Person p;

        p = bill as Person;
        if (p != null)
        {
            Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
        }
    }
}