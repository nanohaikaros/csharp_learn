#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Stack
{
    public class Tester
    {
        static void Main()
        {
            Stack<Int32> intStack = new Stack<Int32>();

            for (int i = 0; i < 8; i++)
            {
                intStack.Push(i * 5);
            }

            Console.Write("intStack values:\t");
            PrintValues(intStack);

            Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());

            Console.Write("intStack values:\t");
            PrintValues(intStack);

            Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());

            Console.Write("intStack values:\t");
            PrintValues(intStack);

            Console.WriteLine("\n(Peek)\t{0}", intStack.Peek());

            Console.Write("intStack values:\t");
            PrintValues(intStack);

            int[] targetArray = new int[12];

            for (int i = 0; i < targetArray.Length; i++)
            {
                targetArray[i] = i * 100 + 100;
            }

            Console.WriteLine("\nTarget array: ");
            PrintValues(targetArray);

            intStack.CopyTo(targetArray, 6);

            Console.WriteLine("\nTarget array after copy: ");
            PrintValues(targetArray);
        }

        public static void PrintValues(IEnumerable<Int32> myCollection)
        {
            IEnumerator<Int32> ennumerator = myCollection.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write("{0} ", ennumerator.Current);
            Console.WriteLine();
        }
    }
}