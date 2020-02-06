#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace StringSplit
{
    public class StringTester
    {
        static void Main()
        {
            string s1 = "One, Two, Three Liberty Associates, Inc.";

            const char Space = ' ';
            const char Comma = ',';

            char[] delimiters = new char[] {
                Space,
                Comma
            };

            string output = "";
            int ctr = 1;

            foreach (string subString in s1.Split(delimiters))
            {
                output += ctr++;
                output += ": ";
                output += subString;
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}