using System;

// class Incrementer
// {
//     public event EventHandler CountedADozen;

//     void DoCount(object source, EventArgs args)
//     {
//         for (int i = 1; i < 100; i++)
//         if (i % 12 == 0)
//             if (CountedADozen !=null)
//                     CountedADozen(source, args);
//     }
// }


// class Incrementer
// {
//     public event Handler CountedADozen;

//     public void DoCount()
//     {
//         for (int i = 1; i < 100; i++)
//             if (i % 12 == 0 && CountedADozen != null)
//                 CountedADozen();
//     }
// }

// class Dozens
// {
//     public int DozensCount { get; private set; }

//     public Dozens (Incrementer incrementer)
//     {
//         DozensCount = 0;
//         incrementer.CountedADozen += IncrementerDozensCount;
//     }

//     void IncrementerDozensCount()
//     {
//         DozensCount++;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Incrementer incrementer = new Incrementer();
//         Dozens dozensCounter = new Dozens(incrementer);

//         incrementer.DoCount();
//         Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//     }
// }


// class Incrementer
// {
//     public event EventHandler CountedADozen;

//     public void DoCount()
//     {
//         for (int i = 1; i < 100; i++)
//             if (i % 12 == 0 && CountedADozen != null)
//                 CountedADozen(this, null);
//     }
// }

// class Dozens
// {
//     public int DozensCount { get; private set; }

//     public Dozens (Incrementer incrementer)
//     {
//         DozensCount = 0;
//         incrementer.CountedADozen += IncrementerDozensCount;
//     }

//     void IncrementerDozensCount(object source, EventArgs e)
//     {
//         DozensCount++;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Incrementer incrementer = new Incrementer();
//         Dozens dozensCounter = new Dozens(incrementer);

//         incrementer.DoCount();
//         Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//     }
// }


// public class IncrementerEventArgs : EventArgs
// {
//     public int IterationCount{ get; set; }
// }

// class Incrementer
// {
//     public event EventHandler<IncrementerEventArgs> CountedADozen;

//     public void DoCount()
//     {
//         IncrementerEventArgs args = new IncrementerEventArgs();
//         for (int i = 1; i < 100; i++)
//             if (i % 12 == 0 && CountedADozen != null)
//             {
//                 args.IterationCount = i;
//                 CountedADozen(this, args);
//             }
//     }
// }

// class Dozens
// {
//     public int DozensCount { get; set; }

//     public Dozens(Incrementer incrementer)
//     {
//         DozensCount = 0;
//         incrementer.CountedADozen += incrementDozensCount;
//     }

//     void incrementDozensCount(object source, IncrementerEventArgs e)
//     {
//         Console.WriteLine("Incrementd at iteration: {0} in {1}", e.IterationCount, source.ToString());
//         DozensCount++;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Incrementer incrementer = new Incrementer();
//         Dozens dozensCounter = new Dozens(incrementer);

//         incrementer.DoCount();
//         Console.WriteLine("Number of dozens = {0}", dozensCounter.DozensCount);
//     }
// }


class Publisher
{
    public event EventHandler SimpleEvent;

    public void RaiseTheEvent() { SimpleEvent(this, null); }
}

class Subscriber
{
    public void MethodA(object o, EventArgs e) { Console.WriteLine("AAA"); }
    public void MethodB(object o, EventArgs e) { Console.WriteLine("BBB"); }
}

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        Subscriber s = new Subscriber();

        p.SimpleEvent += s.MethodA;
        p.SimpleEvent += s.MethodB;
        p.RaiseTheEvent();

        Console.WriteLine("\r\nRemove MethodB"); ;
        p.SimpleEvent -= s.MethodB;
        p.RaiseTheEvent();
    }
}