using System;
using System.IO;

namespace UsingStatement
{
    class Program
    {
        static void Main()
        {
            // using (TextWriter tw = File.CreateText("Lincoln.txt"))
            // {
            //     tw.WriteLine("Four score and seven years ago, ...");
            // }

            // using (TextReader tr = File.OpenText("Lincoln.txt"))
            // {
            //     string InputString;
            //     while (null != (InputString = tr.ReadLine()))
            //         Console.WriteLine(InputString);
            // }

            using (TextWriter tw1 = File.CreateText("Lincoln.txt"),
                              tw2 = File.CreateText("Franklin.txt"))
            {
                tw1.WriteLine("Four score and seven years ago, ...");
                tw2.WriteLine("Early to bed; Early to rise ...");
            }

            using (TextReader tr1 = File.OpenText("Lincoln.txt"),
                              tr2 = File.OpenText("Franklin.txt"))
            {
                string InputString;
                while (null != (InputString = tr1.ReadLine()))
                    Console.WriteLine(InputString);

                while (null != (InputString = tr2.ReadLine()))
                    Console.WriteLine(InputString);
            }
        }
    }
}