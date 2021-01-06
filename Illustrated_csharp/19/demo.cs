// using System;
// using System.Collections;
// using System.Linq;

// class MyClass
// {
// static void Main()
// {
//     int[] numbers = { 2, 12, 5, 15 };
//         IEnumerable<int> lowNums = from n in numbers
//                                    where n < 10
//                                    select n;

//     foreach (var x in lowNums)
//         Console.WriteLine("{0}, ", x);
// }

//     static void Main()
//     {
//         var student = new { Name = "Mary Jones", Age = 19, Major = "History" };
//         Console.WriteLine("{0}, Age {1}, Major: {2}", student.Name, student.Age, student.Major);
//     }

// }

// class Other
// {
//     static public string Name = "Mary Jones";
// }

// class Program
// {
//     static void Main()
//     {
//         string Major = "History";

//         var student = new { Age = 19, Other.Name, Major };

//         Console.WriteLine("{0}, Age {1}, Major: {2}", student.Name, student.Age, student.Major);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };

//         var numsQuery = from n in numbers
//                         where n < 20
//                         select n;

//         var numsMethod = numbers.Where(x => x < 20);

//         int numsCount = (from n in numbers
//                          where n < 20
//                          select n).Count();

//         foreach (var x in numsQuery)
//             Console.Write("{0}, ", x);
//         Console.WriteLine();

//         foreach (var x in numsMethod)
//             Console.WriteLine("{0}, ", x);
//         Console.WriteLine();

//         Console.WriteLine(numsCount);
//     }
// }

// class Program
// {
//     public class Student
//     {
//         public int StID;
//         public string LastName;
//     }

//     public class CourseStudent
//     {
//         public string CourseName;
//         public int StID;
//     }

//     static Student[] students = new Student[] {
//         new Student {StID = 1, LastName = "Carson"},
//         new Student {StID = 2,LastName = "Klassen"},
//         new Student {StID = 3,LastName = "Fleming"},
//     };

//     static CourseStudent[] studentsInCourses = new CourseStudent[] {
//         new CourseStudent {CourseName = "Art", StID = 1},
//         new CourseStudent {CourseName = "Art", StID = 2},
//         new CourseStudent {CourseName = "History", StID = 1},
//         new CourseStudent {CourseName = "History", StID = 3},
//         new CourseStudent {CourseName = "Physics", StID = 3},
//     };

//     static void Main()
//     {
//         var query = from s in students
//                     join c in studentsInCourses on s.StID equals c.StID
//                     where c.CourseName == "History"
//                     select s.LastName;

//         foreach (var q in query)
//             Console.WriteLine("Student taking History: {0}", q);

//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var groupA = new[] { 3, 4, 5, 6 };
//         var groupB = new[] { 6, 7, 8, 9 };

//         var someInts = from a in groupA
//                        from b in groupB
//                        where a > 4 && b <= 8
//                        select new { a, b, sum = a + b };

//         foreach (var a in someInts)
//             Console.WriteLine(a);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var groupA = new[] { 3, 4, 5, 6 };
//         var groupB = new[] { 6, 7, 8, 9 };

//         var someInts = from a in groupA
//                        from b in groupB
//                        let sum = a + b
//                        where sum == 12
//                        select new { a, b, sum };

//         foreach (var a in someInts)
//             Console.WriteLine(a);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var groupA = new[] { 3, 4, 5, 6 };
//         var groupB = new[] { 6, 7, 8, 9 };

//         var someInts = from a in groupA
//                        from b in groupB
//                        let sum = a + b
//                        where sum >= 11
//                        where a == 4
//                        select new { a, b, sum };

//         foreach (var a in someInts)
//             Console.WriteLine(a);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var students = new[] {
//             new {LName="Jones", FName="Mary", Age=19, Major="History"},
//             new {LName="Smith", FName="Bob", Age=20,Major="CompSci"},
//             new {LName="Fleming", FName="Carol", Age=21,Major="History"}
//             };

//         var query = from student in students
//                     orderby student.Age
//                     select student;

//         foreach (var s in query)
//         {
//             Console.WriteLine("{0}, {1}: {2} - {3}", s.LName, s.FName, s.Age, s.Major);
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var students = new[] {
//             new {LName="Jones", FName="Mary", Age=19, Major="History"},
//             new {LName="Smith", FName="Bob", Age=20,Major="CompSci"},
//             new {LName="Fleming", FName="Carol", Age=21,Major="History"}
//             };

//         var query = from s in students
//                     select s;

//         foreach (var q in query)
//             Console.WriteLine("{0}, {1}: Age {2}, {3}", q.LName, q.FName, q.Age, q.Major);

//         var query = from s in students
//                     select s.LName;

//         foreach (var q in query)
//             Console.WriteLine(q);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var students = new[] {
//             new {LName="Jones", FName="Mary", Age=19, Major="History"},
//             new {LName="Smith", FName="Bob", Age=20,Major="CompSci"},
//             new {LName="Fleming", FName="Carol", Age=21,Major="History"}
//             };

//         var query = from s in students
//                     select new { s.LName, s.FName, s.Major };

//         foreach (var q in query)
//             Console.WriteLine("{0} {1} -- {2}", q.FName, q.LName, q.Major);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//          var students = new[] {
//             new {LName="Jones", FName="Mary", Age=19, Major="History"},
//             new {LName="Smith", FName="Bob", Age=20,Major="CompSci"},
//             new {LName="Fleming", FName="Carol", Age=21,Major="History"}
//             };

//         var query = from student in students
//                     group student by student.Major;

//         foreach (var s in query)
//         {
//             Console.WriteLine("{0}", s.Key);

//             foreach (var t in s)
//                 Console.WriteLine("     {0}, {1}", t.LName, t.FName);
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         var groupA = new[] { 3, 4, 5, 6 };
//         var groupB = new[] { 4, 5, 6, 7 };

//         var someInts = from a in groupA
//                        join b in groupB on a equals b
//                        into groupAandB
//                        from c in groupAandB
//                        select c;

//         foreach (var a in someInts)
//             Console.WriteLine("{0} ", a);
//     }
// }


// class Program
// {
// static int[] numbers = new int[] { 2, 4, 6 };

// static void Main()
// {
//     int total = numbers.Sum();
//     int howMany = numbers.Count();

//     Console.WriteLine("Total: {0}, Count: {1}", total, howMany);
// }
// }

// class Program
// {
// static void Main()
// {
//     int[] intaArray = new int[] { 3, 4, 5, 6, 7, 9 };

//     var count1 = Enumerable.Count(intaArray);
//     var firstNum1 = Enumerable.First(intaArray);

//     var count2 = intaArray.Count();
//     var firstNum2 = intaArray.First();

//     Console.WriteLine("Count: {0}, FirstNumber: {1}", count1, firstNum1);
//     Console.WriteLine("Count: {0}, FirstNumber: {1}", count2, firstNum2);
// }

// static void Mian()
// {
//     var numbers = new int[] { 2, 6, 4, 8, 10 };

//     int howMany = (from n in numbers
//                    where n < 7
//                    select n).Count();

//     Console.WriteLine("Count: {0}", howMany);
// }


//     static void Main()
//     {
//         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

//         var countOdd = intArray.Count(n => n % 2 == 1);

//         Console.WriteLine("Count of odd numbers: {0}", countOdd);
//     }
// }


// class Program
// {
//     static bool IsOdd(int x)
//     {
//         return x % 2 == 1;
//     }

//     static void Main()
//     {
//         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

//         Func<int, bool> myDel = new Func<int, bool>(IsOdd);
//         var countOdd = intArray.Count(myDel);

//         Console.WriteLine("Count of odd numbers: {0}", countOdd);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

//         Func<int, bool> myDel = delegate (int x)
//         {
//             return x % 2 == 1;
//         };

//         var countOdd = intArray.Count(myDel);

//         Console.WriteLine("Count of odd numbers: {0}", countOdd);
//     }
// }


// using System;
// using System.Xml.Linq;

// class Program
// {
//     static void Main()
//     {
//         XDocument employess1 =
//         new XDocument(
//             new XElement("Employess",
//             new XElement("Name", "Bob Smith"),
//             new XElement("Name", "Sally Jones")
//             )
//         );

//         employess1.Save("EmployeesFile.xml");

//         XDocument employees2 = XDocument.Load("EmployeesFile.xml");

//         Console.WriteLine(employees2);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         XDocument employeeDoc =
//         new XDocument(
//             new XElement("Employees",
//             new XElement("Employee",
//             new XElement("Name", "Bob Smith"),
//             new XElement("PhoneNumber", "408-555-1000")),

//             new XElement("Employee",
//             new XElement("Name", "Sally Jones"),
//             new XElement("PhoneNumber", "415-555-2000"),
//             new XElement("PhoneNumber", "415-555-2001"))
//             )
//         );

//         Console.WriteLine(employeeDoc);
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Xml.Linq;

// class Program
// {
//     static void Main()
//     {
//         XDocument employeeDoc =
//         new XDocument(
//             new XElement("Employees",
//             new XElement("Employee",
//             new XElement("Name", "Bob Simth"),
//             new XElement("PhoneNumber", "408-555-1000")),
//             new XElement("Employee",
//             new XElement("Name", "Sally Jones"),
//             new XElement("PhoneNumber", "415-555-2000"),
//             new XElement("PhoneNumber", "415-555-2001"))
//             )
//         );

//         XElement root = employeeDoc.Element("Employees");
//         IEnumerable<XElement> employees = root.Elements();

//         foreach (XElement emp in employees)
//         {
//             XElement empNameNode = emp.Element("Name");
//             Console.WriteLine(empNameNode.Value);

//             IEnumerable<XElement> empPhones = emp.Elements("PhoneNumber");
//             foreach (XElement phone in empPhones)
//                 Console.WriteLine("  {0}", phone.Value);
//         }
//     }
// }

// using System;
// using System.Xml.Linq;

// class Program
// {
// static void Main()
// {
//     XDocument xd = new XDocument(
//         new XElement("root",
//         new XElement("first")
//         )
//     );

//     Console.WriteLine("Original tree");
//     Console.WriteLine(xd);
//     Console.WriteLine();

//     XElement rt = xd.Element("root");

//     rt.Add(new XElement("second"));

//     rt.Add(new XElement("third"),
//     new XComment("Important Comment"),
//     new XElement("fourth"));

//     Console.WriteLine("Modified tree");
//     Console.WriteLine(xd);
// }

// static void main()
// {
//     XDocument xd = new XDocument(
//         new Xelement("root",
//         new XAttribute("color", "red"),
//         new XAttribute("size", "large"),
//         new XElement("first")
//         // new XElement("second")
//         )
//     );

//     Console.WriteLine(xd);
//     Console.WriteLine();

//     XElement rt = xd.Element("root");

//     XAttribute color = rt.Attribute("color");
//     XAttribute size = rt.Attribute("size");

//     Console.WriteLine("color is {0}", color.Value);
//     Console.WriteLine("size is {0}", size.Value);
// }


// static void Main()
// {
//     XDocument xd = new XDocument(
//         new Xelement("root",
//         new XAttribute("color", "red"),
//         new XAttribute("size", "large"),
//         new XElement("first")
//         )
//     );

//     XElement rt = xd.Element("root");

//     rt.Attribute("color").Remove();
//     rt.SetAttributeValue("size", null);

//     Console.WriteLine(xd);
// }

//     static void Main()
//     {
//         XDocument xd = new XDocument(
//             new Xelement("root",
//             new XAttribute("color", "red"),
//             new XAttribute("size", "large"),
//             new XElement("first")));

//         XElement rt = xd.Element("root");

//         rt.SetAttributeValue("size", "medium");
//         rt.SetAttributeValue("width", "narrow");

//         Console.WriteLine(xd);
//         Console.WriteLine();
//     }
// }



using System;
using System.Xml.Linq;
using System.Linq;
class Program
{
    // static void Main()
    // {
    //     XDocument xd = new XDocument(
    //         new XDeclaration("1.0", "utf-8", "yes"),
    //         new XComment("This is a comment"),
    //         new XProcessingInstruction("xml-stylessheet",
    //         @"href=""stories.css"" type=""txt/css"""),
    //         new XElement("root",
    //         new XElement("first"),
    //         new XElement("second")
    //         )
    //     );
    // }

    // static void Main()
    // {
    //     XDocument xd = new XDocument(
    //         new XElement("MyElements",
    //         new XElement("first",
    //         new XAttribute("color", "red"),
    //         new XAttribute("size", "small")),
    //         new XElement("second",
    //         new XAttribute("color", "red"),
    //         new XAttribute("size", "medium")),
    //         new XElement("third",
    //         new XAttribute("color", "blue"),
    //         new XAttribute("size", "large")))
    //     );

    //     Console.WriteLine(xd);
    //     xd.Save("SimpleSample.xml");
    // }

    // static void Main()
    // {
    //     XDocument xd = XDocument.Load("SimpleSample.xml");
    //     XElement rt = xd.Element("MyElements");

    //     var xyz = from e in rt.Elements()
    //               where e.Name.ToString().Length == 5
    //               select e;

    //     foreach (XElement x in xyz)
    //         Console.WriteLine(x.Name.ToString());

    //     Console.WriteLine();
    //     foreach (XElement x in xyz)
    //         Console.WriteLine("Name: {0}, color: {1}, size: {2}",
    //                         x.Name,
    //                         x.Attribute("color").Value,
    //                         x.Attribute("size").Value);
    // }

    static void Main()
    {
        XDocument xd = XDocument.Load("SimpleSample.xml");
        XElement rt = xd.Element("MyElements");

        var xyz = from e in rt.Elements()
                  select new { e.Name, color = e.Attribute("color") };

        foreach (var x in xyz)
            Console.WriteLine(x);

        Console.WriteLine();
        foreach (var x in xyz)
            Console.WriteLine("{0,-6}, color: {1,-7}", x.Name, x.color.Value);
    }
}