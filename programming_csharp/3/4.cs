using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicConstants
{
    class SymbolicConstants
    {
        static void Main(string[] args)
        {
            const int FreezingPoint = 32;
            const int BoilingPoint = 212;

            System.Console.WriteLine("Freezing point of water: {0}", FreezingPoint);
            System.Console.WriteLine("Boiling point of water: {0}", BoilingPoint);

            BoilingPoint = 21;  // Error
        }
    }
}