#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
#endregion

namespace AsynchDelegates
{
    public class ClassWithDelegate
    {
        public delegate int DelegateThatReturnsInt();
        public event DelegateThatReturnsInt theDelegate;

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(500);

                if (theDelegate != null)
                {
                    foreach (DelegateThatReturnsInt del in theDelegate.GetInvocationList())
                    {
                        del.BeginInvoke(new AsyncCallback(ResultReturned), del);
                    }
                }
            }
        }

        private void ResultReturned(IAsyncResult iar)
        {
            DelegateThatReturnsInt del = (DelegateThatReturnsInt)iar.AsyncState;

            int result = del.EndInvoke(iar);

            Console.WriteLine("Delegate returned result: {0}", result);
        }
    }

    public class FirstSubscriber
    {
        private int myCounter = 0;
        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(DisplayCounter);
        }

        public int DisplayCounter()
        {
            Console.WriteLine("Busy in DisplayCounter...");
            Thread.Sleep(10000);
            Console.WriteLine("Done with work in DisplayCounter...");
            return ++myCounter;
        }
    }

    public class SecondSubscriber
    {
        private int myCounter = 0;

        public void Subscribe(ClassWithDelegate theClassWithDelegate)
        {
            theClassWithDelegate.theDelegate += new ClassWithDelegate.DelegateThatReturnsInt(Doubler);
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
            ClassWithDelegate theClassWithDelegate = new ClassWithDelegate();

            FirstSubscriber fs = new FirstSubscriber();
            fs.Subscribe(theClassWithDelegate);

            SecondSubscriber ss = new SecondSubscriber();
            ss.Subscribe(theClassWithDelegate);

            theClassWithDelegate.Run();
        }
    }
}