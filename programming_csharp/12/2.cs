#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace MuiticastDelegates
{
    public class MyClassWithDelegate
    {
        public delegate void StringDelegate(string s);
    }

    public class MyImplementingClass
    {
        public static void WriteString(string s)
        {
            Console.WriteLine("Writing string {0}", s);
        }

        public static void LogString(string s)
        {
            Console.WriteLine("Logging string {0}", s);
        }

        public static void TransmitString(string s)
        {
            Console.WriteLine("Transmitting string {0}", s);
        }
    }

    public class Test
    {
        public static void Main()
        {
            MyClassWithDelegate.StringDelegate Writer, Logger, Transmitter;

            MyClassWithDelegate.StringDelegate MyMulticastDelegate;

            Writer = new MyClassWithDelegate.StringDelegate(MyImplementingClass.WriteString);
            Logger = new MyClassWithDelegate.StringDelegate(MyImplementingClass.LogString);
            Transmitter = new MyClassWithDelegate.StringDelegate(MyImplementingClass.TransmitString);

            Writer("String passed to Writer\n");

            Logger("String passed to Logger\n");

            Transmitter("String passed to Transmitter\n");

            Console.WriteLine("myMulticastSelegate = Writer + Logger");

            MyMulticastDelegate = Writer + Logger;

            MyMulticastDelegate("First string passed to Collector");

            Console.WriteLine("\nmyMulticastDelegate += Transmitter");

            MyMulticastDelegate += Transmitter;

            MyMulticastDelegate("Second string passed to Collector");

            Console.WriteLine("\nmyMuleicastDelegate -= Logger");

            MyMulticastDelegate -= Logger;

            MyMulticastDelegate("Third string passed to Collector");
        }
    }
}