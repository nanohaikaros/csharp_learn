#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Delegates
{
    public enum Comparison
    {
        theFirstComesFirst = 1,
        theSecondComesFirst = 2
    }

    public class Pair<T>
    {
        private T[] thePair = new T[2];

        public delegate Comparison WhichIsFirst(T obj1, T obj2);

        public Pair(T firstObject, T secondObject)
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }

        public void Sort(WhichIsFirst theDelegatedFunc)
        {
            if (theDelegatedFunc(thePair[0], thePair[1]) == Comparison.theSecondComesFirst)
            {
                T temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        public void ReverseSort(WhichIsFirst theDelegatedFunc)
        {
            if (theDelegatedFunc(thePair[0], thePair[1]) == Comparison.theFirstComesFirst)
            {
                T temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        public override string ToString()
        {
            return thePair[0].ToString() + ", " + thePair[1].ToString();
        }
    }

    public class Dog
    {
        private int weight;
        public Dog(int weight)
        {
            this.weight = weight;
        }

        public static Comparison WhichDogComesFirst(Dog d1, Dog d2)
        {
            return d1.weight > d2.weight ? Comparison.theSecondComesFirst : Comparison.theFirstComesFirst;
        }

        public override string ToString()
        {
            return weight.ToString();
        }
    }

    public class Student
    {
        private string name;
        public Student(string name)
        {
            this.name = name;
        }

        public static Comparison WhichDogComesFirst(Student s1, Student s2)
        {
            return (String.Compare(s1.name, s2.name) < 0 ? Comparison.theFirstComesFirst : Comparison.theSecondComesFirst);
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class theFirstComesFirst
    {
        public static void Main()
        {
            Student Jesse = new Student("Jesse");
            Student Stacey = new Student("Stacey");
            Dog Milo = new Dog(65);
            Dog Fred = new Dog(12);

            Pair<Student> StudentPair = new Pair<Student>(Jesse, Stacey);
            Pair<Dog> dogPair = new Pair<Dog>(Milo, Fred);
            Console.WriteLine("studentPair\t\t\t: {0}", StudentPair.ToString());
            Console.WriteLine("dogPair\t\t\t\t: {0}", dogPair.ToString());

            Pair<Student>.WhichIsFirst theStudentDelegate = new Pair<Student>.WhichIsFirst(Student.WhichDogComesFirst);

            Pair<Dog>.WhichIsFirst theDogDelegate = new Pair<Dog>.WhichIsFirst(Dog.WhichDogComesFirst);

            StudentPair.Sort(theStudentDelegate);
            Console.WriteLine("After Sort studentPair\t\t: {0}", StudentPair.ToString());
            StudentPair.ReverseSort(theStudentDelegate);
            Console.WriteLine("After ReverseSort studentPair\t: {0}", StudentPair.ToString());

            dogPair.Sort(theDogDelegate);
            Console.WriteLine("After Sort dogPair\t\t: {0}", dogPair.ToString());
            dogPair.ReverseSort(theDogDelegate);
            Console.WriteLine("After ReverseSort dogPair\t: {0}", dogPair.ToString());
        }
    }
}