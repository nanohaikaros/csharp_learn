#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace CustomExceptions
{
    public class MyCustomExcetion : System.ApplicationException
    {
        public MyCustomExcetion(string message):
        base(message)
        {

        }
    }

    public class Test
    {
        public static void Main()
        {
            Test t = new Test();
            t.TestFunc();
        }

        public void TestFunc()
        {
            try
            {
                Console.WriteLine("Open file here");
                double a = 0;
                double b = 5;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
                Console.WriteLine("This line may or may not print");
            }

            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException! Msg: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}\n", e.HelpLink);
            }

            catch (MyCustomExcetion e)
            {
                Console.WriteLine("\nMyCustomException! Msg: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}\n", e.HelpLink);
            }
            catch
            {
                Console.WriteLine("Unknown exception caught");
            }
            finally
            {
                Console.WriteLine("Close file here.");
            }
        }

        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException e = new DivideByZeroException();
                e.HelpLink = "http://www.libertyassociates.com";
                throw e;
            }
            if (a == 0)
            {
                MyCustomExcetion e = new MyCustomExcetion("Can't have zero divisor");
                e.HelpLink = "http://www.libertyassociates.com/NoZeroDivisor.html";
                throw e;
            }
            return a / b;
        }
    }
}