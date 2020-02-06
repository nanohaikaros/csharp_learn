#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
#endregion

namespace CaptureCollection
{
    class Test
    {
        public static void Main()
        {
            string string1 = "04:03:27 Jesse 0.0.0.127 Liberty ";

            Regex theReg = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)\s");

            MatchCollection theMatches = theReg.Matches(string1);

            foreach (Match theMatch in theMatches)
            {
                if (theMatch.Length != 0)
                {
                    Console.WriteLine("theMatch: {0}", theMatch.ToString());
                    Console.WriteLine("time: {0}", theMatch.Groups["time"]);
                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);
                    Console.WriteLine("Company: {0}", theMatch.Groups["company"]);

                    foreach (Capture cap in theMatch.Groups["company"].Captures)
                    {
                        Console.WriteLine("cap: {0}", cap.ToString());
                    }
                }
            }
        }
    }
}