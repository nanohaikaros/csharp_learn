#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace UsingStringBuilder
{
    public class StringTester
    {
        static void Main()
        {
            string s1 = "One,Two,Three Liberty Associates, Inc.";

            const char Space = ' ';
            const char Comma = ',';

            char[] delimiters = new char[] {
                Space,
                Comma
            };

            StringBuilder output = new StringBuilder();
            int ctr = 1;

            foreach(string subString in s1.Split(delimiters))
            {
                output.AppendFormat("{0}: {1}\n", ctr++, subString);
            }
            Console.WriteLine(output);
        }
    }
}