// using System;
// using System.Net;
// using System.Diagnostics;

// class MyDoenloadString
// {
//     Stopwatch sw = new Stopwatch();

//     public void DoRun()
//     {
//         const int LargeNumber = 6000000;
//         sw.Start();

//         int t1 = CountCharacters(1, "http://www.microsoft.com");
//         int t2 = CountCharacters(2, "http://www.illustratedcsharp.com");

//         CountToALargeNumber(1, LargeNumber);
//         CountToALargeNumber(2, LargeNumber);
//         CountToALargeNumber(3, LargeNumber);
//         CountToALargeNumber(4, LargeNumber);

//         Console.WriteLine("Chars in http://www.microsoft.com        : {0}", t1);
//         Console.WriteLine("Chars in http://www.illustratedcsahrp.com: {0}", t2);
//     }

//     private int CountCharacters(int id, string uriString)
//     {
//         WebClient wc1 = new WebClient();
//         Console.WriteLine("String call {0}  :   {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);

//         string result = wc1.DownloadString(new Uri(uriString));

//         Console.WriteLine(" Call {0} completed: {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);

//         return result.Length;
//     }

//     private void CountToALargeNumber(int id, int value)
//     {
//         for (long i = 0; i < value; i++)
//             ;
//         Console.WriteLine(" End counting {0}    :   {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyDoenloadString ds = new MyDoenloadString();
//         ds.DoRun();
//     }
// }


// using System;
// using System.Net;
// using System.Diagnostics;
// using System.Threading.Tasks;

// class MyDoenloadString
// {
//     Stopwatch sw = new Stopwatch();

//     public void DoRun()
//     {
//         const int LargeNumber = 6000000;
//         sw.Start();

//         Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
//         Task<int> t2 = CountCharactersAsync(2, "http://www.illustratedcsharp.com");
//         CountToALargeNumber(1, LargeNumber);
//         CountToALargeNumber(2, LargeNumber);
//         CountToALargeNumber(3, LargeNumber);
//         CountToALargeNumber(4, LargeNumber);

//         Console.WriteLine("Chars in http://www.microsoft.com        : {0}", t1.Result);
//         Console.WriteLine("Chars in http://www.illustratedcsharp.com: {0}", t2.Result);
//     }

//     private async Task<int> CountCharactersAsync(int id, string site)
//     {
//         WebClient wc = new WebClient();
//         Console.WriteLine("String call {0}  : {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);

//         string result = await wc.DownloadStringTaskAsync(new Uri(site));
//         Console.WriteLine(" Call {0} completed: {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);

//         return result.Length;
//     }

//     private void CountToALargeNumber(int id, int value)
//     {
//         for (long i = 0; i < value; i++)
//             ;
//         Console.WriteLine(" End counting {0}    :   {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyDoenloadString ds = new MyDoenloadString();
//         ds.DoRun();
//     }
// }


// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static void Main()
//     {
//         Task<int> value = DoAsyncStuff.CalculateSumAsync(5, 6);
//         Console.WriteLine("Value: {0}", value.Result);
//     }
// }

// static class DoAsyncStuff
// {
//     public static async Task<int> CalculateSumAsync(int i1, int i2)
//     {
//         int sum = await Task.Run(() => GetSum(i1, i2));
//         return sum;
//     }

//     private static int GetSum(int i1, int i2)
//     {
//         return i1 + i2;
//     }
// }


// using System;
// using System.Threading.Tasks;
// class Program
// {
//     static void Main()
//     {
//         Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);
//         someTask.Wait();
//         Console.WriteLine("Value: {0}", value.Result);
//     }
// }

// static class DoAsyncStuff
// {
//     public static async Task CalculateSumAsync(int i1, int i2)
//     {
//         int value = await Task.Run(() => GetSum(i1, i2));
//         Console.WriteLine("Value: {0}", value);
//     }

//     private static int GetSum(int i1, int i2)
//     {
//         return i1 + i2;
//     }
// }


// using System;
// using System.Threading;
// using System.Threading.Tasks;
// class Program
// {
//     static void Main()
//     {
//         DoAsyncStuff.CalculateSumAsync(5, 6);
//         Thread.Sleep(200);
//         Console.WriteLine("Program Exiting");
//     }
// }

// static class DoAsyncStuff
// {
//     public static async void CalculateSumAsync(int i1, int i2)
//     {
//         int value = await Task.Run(() => GetSum(i1, i2));
//         Console.WriteLine("Value: {0}", value);
//     }

//     private static int GetSum(int i1, int i2)
//     {
//         return i1 + i2;
//     }
// }

// using System;
// using System.Threading;
// using System.Threading.Tasks;

// class MyClass
// {
//     public int Get10()
//     {
//         return 10;
//     }

//     public async Task DoWorkAsync()
//     {
//         Func<int> ten = new Func<int>(Get10);
//         int a = await Task.Run(ten);

//         int b = await Task.Run(new Func<int>(Get10));

//         int c = await Task.Run(() => { return 10; });

//         Console.WriteLine("{0} {1} {2}", a, b, c);
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Task t = (new MyClass()).DoWorkAsync();
//             t.Wait();
//         } 
//     }
// }


// static class MyClass
// {
//     public static async Task DoWorkAsync()
//     {
//         await Task.Run(() => Console.WriteLine(5.ToString()));

//         Console.WriteLine((await Task.Run(() => 6)).ToString());

//         await Task.Run(() => Task.Run(() => Console.WriteLine(7.ToString())));

//         int value = await Task.Run(() => Task.Run(() => 8));
//         Console.WriteLine(value.ToString());
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Task t = MyClass.DoWorkAsync();
//         t.Wait();
//         Console.WriteLine("Press Enter key to exit");
//         Console.Read();
//     }
// }


// static class MyClass
// {
//     private static int GetSum(int i1, int i2)
//     {
//         return i1 + i2;
//     }

//     public static async Task DoWorkAsync()
//     {
//         int value = await Task.Run(() => GetSum(5, 6));
//         Console.WriteLine(value.ToString());
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Task t = MyClass.DoWorkAsync();
//         t.Wait();
//         Console.WriteLine("press Enter key to exit");
//         Console.Read();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         CancellationTokenSource cts = new CancellationTokenSource();
//         CancellationToken token = cts.Token;

//         MyClass mc = new MyClass();
//         Task t = mc.RunAsync(token);

//         // Thread.Sleep(3000);
//         // cts.Cancel();

//         t.Wait();
//         Console.WriteLine("Was Canaelled: {0}", token.IsCancellationRequested);
//     }
// }

// class MyClass
// {
//     public async Task RunAsync(CancellationToken ct)
//     {
//         if (ct.IsCancellationRequested)
//             return;
//         await Task.Run(() => CycleMethod(ct), ct);
//     }

//     void CycleMethod(CancellationToken ct)
//     {
//         Console.WriteLine("Starting CycleMethod");

//         const int max = 5;
//         for (int i = 0; i < max; i++)
//         {
//             if (ct.IsCancellationRequested)
//                 return;
//             Thread.Sleep(1000);
//             Console.WriteLine(" {0} of {1} itertions completed", i + 1, max);
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Task t = BadAsync();
//         t.Wait();
//         Console.WriteLine("Task Status   : {0}", t.Status);
//         Console.WriteLine("Task IsFaulted: {0}", t.IsFaulted);
//     }

//     static async Task BadAsync()
//     {
//         try
//         {
//             await Task.Run(() => { throw new Exception(); });
//         }
//         catch
//         {
//             Console.WriteLine("Exception in BadAsync");
//         }
//     }
// }

// static class MyDownloadString
// {
//     public static void DoRun()
//     {
//         Task<int> t = CountCharactersAsnyc("http://illustratedcsharp.com");

//         t.Wait();
//         Console.WriteLine("The task has finished, returning value {0}.", t.Result);
//     }

//     private static async Task<int> CountCharactersAsync(string site)
//     {
//         string result = await new WebClient().DownloadStringTaskAsync(new Uri(site));
//         return result.Length;
//     }
// }

// class Prgoram
// {
//     static void Main()
//     {
//         MyDownloadString.DoRun();
//     }
// }


// using System.Diagnostics;
// using System.Net;

// class MyDownloadString
// {
//     Stopwatch sw = new Stopwatch();

//     public void DoRun()
//     {
//         sw.Start();

//         Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
//         Task<int> t2 = CountCharactersAsync(2, "http://www.illustratedcsharp.com");

//         // Task<int>[] tasks = new Task<int>[] { t1, t2 };
//         // Task.WaitAll(tasks);
//         // Task.WaitAny(tasks);

//         Console.WriteLine("Task 1: {0}Finished", t1.IsCompleted ? "" : "Not");
//         Console.WriteLine("Task 2: {0}Finished", t2.IsCompleted ? "" : "Not");
//         Console.Read();
//     }

//     private async Task<int> CountCharactersAsync(int id, string site)
//     {
//         WebClient wc = new WebClient();
//         string result = await wc.DownloadStringTaskAsync(new Uri(site));
//         Console.WriteLine(" Call {0} completed: {1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);
//         return result.Length;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyDownloadString ds = new MyDownloadString();
//         ds.DoRun();
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Net;
// using System.Threading.Tasks;

// class MyDownloadString
// {
//     public void DoRun()
//     {
//         Task<int> t = CountCharactersAsync("http://www.microsoft.com", "http://www.illustratedcsharp.com");

//         Console.WriteLine("DoRun:   Task {0}Finished", t.IsCanceled ? "" : "Not");
//         Console.WriteLine("DoRun:   Result = {0}", t.Result);
//     }

//     private async Task<int> CountCharactersAsync(string site1, string site2)
//     {
//         WebClient wc1 = new WebClient();
//         WebClient wc2 = new WebClient();
//         Task<string> t1 = wc1.DownloadStringTaskAsync(new Uri(site1));
//         Task<string> t2 = wc1.DownloadStringTaskAsync(new Uri(site2));

//         List<Task<string>> tasks = new List<Task<string>>();
//         tasks.Add(t1);
//         tasks.Add(t2);

//         await Task.WhenAll(tasks);

//         Console.WriteLine(" CCA:    T1 {0}Finished", t1.IsCompleted ? "" : "Not ");
//         Console.WriteLine(" CCA:    T2 {0}Finished", t2.IsCompleted ? "" : "Not ");

//         return t1.IsCompleted ? t1.Result.Length : t2.Result.Length;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyDownloadString ds = new MyDownloadString();
//         ds.DoRun();
//     }
// }


// using System.Diagnostics;
// class Simple
// {
//     Stopwatch sw = new Stopwatch();

//     public void DoRun()
//     {
//         Console.WriteLine("Calller: Before call"); ;
//         ShowDelayAsync();
//         Console.WriteLine("Caller: After call");
//     }

//     private async void ShowDelayAsync()
//     {
//         sw.Start();
//         Console.WriteLine(" Before Delay: {0}", sw.ElapsedMilliseconds);
//         await Task.Delay(1000);
//         Console.WriteLine(" After Delay: {0}", sw.ElapsedMilliseconds);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Simple ds = new Simple();
//         ds.DoRun();
//         Console.Read();
//     }
// }


// using System;
// using System.Threading.Tasks;

// namespace ExampleParalleFor
// {
//     class Program
//     {
//         // static void Main()
//         // {
//         //     Parallel.For(0, 15, i => Console.WriteLine("The square of {0} is {1}", i, i * i));
//         // }

//         static void Main()
//         {
//             const int maxValues = 50;
//             int[] squares = new int[maxValues];

//             Parallel.For(0, maxValues, i => squares[i] = i * i);
//         }
//     }
// }

// using System;
// using System.Threading.Tasks;

// namespace ParallelForeach1
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] squares = new string[] {
//                 "We", "hold", "these", "truths", "to", "be", "self-evident",
//                 "that", "all", "men", "are", "created", "equal"
//             };

//             Parallel.ForEach(squares, i => Console.WriteLine(string.Format("{0} has {1} letters", i, i.Length)));
//         }
//     }
// }


// using System;
// using System.Threading;

// delegate long MyDel(int first, int second);

// class Program
// {
//     static long Sum(int x, int y)
//     {
//         Console.WriteLine(" Inside Sum");
//         Thread.Sleep(100);

//         return x + y;
//     }

//     static void Main()
//     {
//         MyDel del = new MyDel(Sum);

//         Console.WriteLine("Before BeginInvoke");
//         IAsyncResult iar = del.BeginInvoke(3, 5, null, null);
//         Console.WriteLine("After BeginInvoke");

//         Console.WriteLine("Doing stuff");

//         long result = del.EndInvoke(iar);
//         Console.WriteLine("After EndInvoke: {0}", result);
//     }
// }

// delegate long MyDel(int first, int second);

// class Program
// {
//     static long Sum(int x, int y)
//     {
//         Console.WriteLine(" Inside Sum");
//         Thread.Sleep(100);

//         return x + y;
//     }

//     static void Main()
//     {
//         MyDel del = new MyDel(Sum);

//         IAsyncResult iar = del.BeginInvoke(3, 5, null, null);
//         Console.WriteLine("After BeginInvoke");

//         while (!iar.IsCompleted)
//         {
//             Console.WriteLine("Not Done");

//             for (long i = 0; i < 10000000; i++)
//                 ;
//         }

//         Console.WriteLine("Done");

//         long result = del.EndInvoke(iar);
//         Console.WriteLine("Result: {0}", result);
//     }
// }


// using System;
// using System.Runtime.Remoting.Messaging;
// using System.Threading;

// delegate long MyDel(int first, int second);

// class Program
// {
//     static long Sum(int x, int y)
//     {
//         Console.WriteLine(" Inside Sum");
//         Thread.Sleep(1000);
//         return x + y;
//     }

//     static void CallWhenDone(IAsyncResult iar)
//     {
//         Console.WriteLine(" Inside CallWhenDone.");
//         AsyncResult ar = (AsyncResult)iar;
//         MyDel del = (MyDel)ar.AsyncDelegate;

//         long result = del.EndInvoke(iar);
//         Console.WriteLine(" The result is: {0}.", result);
//     }

//     static void Main()
//     {
//         MyDel del = new MyDel(Sum);

//         Console.WriteLine("Before BeginInvoke");
//         IAsyncResult iar = del.BeginInvoke(3, 5, new AsyncCallback(CallWhenDone), null);

//         Console.WriteLine("Doing more work in Main.");
//         Thread.Sleep(500);
//         Console.WriteLine("Done with Main. Exiting");
//     }
// }


using System;
using System.Threading;

namespace Timers
{
    class Program
    {
        int TimesCalled = 0;

        void Display(object state)
        {
            Console.WriteLine("{0} {1}", (string)state, ++TimesCalled);
        }

        static void Main()
        {
            Program p = new Program();

            Timer myTimer = new Timer(p.Display, "Processing timer event", 2000, 1000);
            Console.WriteLine("Timer started.");

            Console.ReadLine();
        }
    }
}