#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
#endregion

namespace RegExGroup
{
    class Test
    {
        public static void Main()
        {
            string string1 = "04:03:27 127.0.0.0 LibertyAssociates.com";

            Regex theReg = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<site>\S+)");

            MatchCollection theMatches = theReg.Matches(string1);

            foreach (Match theMatche in theMatches)
            {
                if (theMatche.Length != 0)
                {
                    Console.WriteLine("\ntheMatch: {0}", theMatche.ToString());
                    Console.WriteLine("time: {0}", theMatche.Groups["time"]);
                    Console.WriteLine("ip: {0}", theMatche.Groups["ip"]);
                    Console.WriteLine("site: {0}", theMatche.Groups["site"]);
                }
            }
        }
    }
}