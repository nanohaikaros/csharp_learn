#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
#endregion

namespace UsingMatchCollection
{
    class Test
    {
        public static void Main()
        {
            string string1 = "This is a test string";

            Regex theReg = new Regex(@"{\S+)\s");

            MatchCollection theMatches = theReg.Matches(string1);

            foreach (Match theMatche in theMatches)
            {
                Console.WriteLine("theMatch.Length: {0}", theMatche.Length);

                if (theMatche.Length != 0)
                {
                    Console.WriteLine("theMatch: {0}", theMatche.ToString());
                }
            }
        }
    }
}