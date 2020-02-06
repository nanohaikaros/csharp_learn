#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
#endregion

namespace InvokingDelegaedMethodsManually
{
    public class ClassWithDelegate
    {
        public delegate int DelegateThatReturnInt();
        public DelegateThatReturnInt theDelegate;

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(500);

                if (theDelegate != null)
                {
                    foreach (DelegateThatReturnInt del in theDelegate.GetInvocationList())
                    {
                        int result = del();
                        Console.WriteLine("Delegated fired! Returnedresult: {0}", result);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    public class FirstSubscriber
    {
        private int myCounter = 0;

        public void SUbscribe(ClassWithDelegate theClasWithDelegate)
        {
            theClasWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnInt(DisplayCounter);
        }

        public int DisplayCounter()
        {
            return ++myCounter;
        }
    }

    public class SecondSubscriber
    {
        private int myCounter = 0;

        public void SUbscribe(ClassWithDelegate theClasWithDelegate)
        {
            theClasWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnInt(Doubler);
        }

        public int Doubler()
        {
            return myCounter += 2;
        }
    }

    public class Test
    {
        public static void Main()
        {
            ClassWithDelegate theClasWithDelegate = new ClassWithDelegate();

            FirstSubscriber fs = new FirstSubscriber();
            fs.SUbscribe(theClasWithDelegate);

            SecondSubscriber ss = new SecondSubscriber();
            ss.SUbscribe(theClasWithDelegate);

            theClasWithDelegate.Run();
        }
    }
}