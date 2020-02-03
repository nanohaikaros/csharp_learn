using System;
using System.Collections.Generic;
using System.Text;

namespace UnitializedVariable
{
    class UnitializedVariable
    {
        static void Main()
        {
            int myInt;
            // Error
            System.Console.WriteLine("Uninitialized, myInt: {0}", myInt);
            myInt = 5;
            System.Console.WriteLine("Assigned, myInt: {0}", myInt);
        }
    }
}