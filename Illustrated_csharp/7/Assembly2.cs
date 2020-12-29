using System;
using BaseClassNS;

namespace UsersBaseClass
{
    class DerivedClass : MyBaseClass
    {

    }

    class Program
    {
        static void Main()
        {
            DerivedClass mdc = new DerivedClass();
            mdc.PrintMe();
        }
    }
}