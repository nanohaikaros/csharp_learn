using System;
using System.Collections.Generic;
using System.Text;

namespace ContinueBreak
{
    class ContinueBreak
    {
        static void Main(string[] args)
        {
            string signal = "O";
            while (signal != "X")
            {
                Console.Write("Enter a signal: ");
                signal = Console.ReadLine();
                Console.WriteLine("Received: {0}", signal);

                if (signal == "A")
                {
                    Console.WriteLine("Fault! Abort\n");
                    break;
                }

                if (signal == "O")
                {
                    Console.WriteLine("All is well.\n");
                    continue;
                }

                Console.WriteLine("{0} -- raise alarm!\n", signal);
            }
        }
    }
}