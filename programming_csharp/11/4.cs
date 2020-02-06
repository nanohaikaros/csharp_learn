#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace SpecifyingCaughtException
{
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
                double a = 5;
                double b = 0;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
            }

            catch (System.DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("ArithmeticException caught!");
            }
            catch
            {
                Console.WriteLine("Unknown exception caught");
            }
        }

        public double DoDivide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            if (a == 0)
                throw new System.ArgumentException();
        }
    }
}