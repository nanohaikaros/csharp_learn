using System;

namespace Demo
{
    class MyClass
    {
        static void Main()
        {
            int x = 10;
            int z;

            {
                int y = 20;
                z = x + y;

                top: y = 30;
            }

            if (x <= 10)
                z = x - 1;

            if (x >= 20)
            {
                x = x - 5;
                y = x + z;
            }

            if (x <= 10)
                z = x - 1;
            else
            {
                x = x - 5;
                y = x + z;
            }

            int x = 3;
            while (x > 0)
            {
                Console.WriteLine("x: {0}", x);
                x--;
            }
            Console.WriteLine("Out of loop");

            int x = 0;
            do
            {
                Console.WriteLine("x is {0}", x++);
            } while (x < 3);

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Inside loop. i: {0}", i);
            Console.WriteLine("Out of Loop");

            const int MaxI = 5;
            for (int i = 0, j = 10; i < MaxI; i++, j += 10)
            {
                Console.WriteLine("{0}, {1}", i, j);
            }

            for (int x = 1; x < 6; x++)
            {
                switch(x)
                {
                    case 2:
                        Console.WriteLine("x is {0} -- In Case 2", x);
                        break;

                    case 5:
                        Console.WriteLine("x is {0} -- In Case 5", x);
                        break;

                    default:
                        Console.WriteLine("x is {0} -- In Default case", x);
                        break;
                }
            }

            for (int x = 1; x < 6; x++)
            {
                switch(x)
                {
                    case 5:
                        Console.WriteLine("x is {0} -- In Case 5", x);
                        break;
                }
            }

            for (int x = 1; x < 4; x++)
            {
                switch(x)
                {
                    default:
                        Console.WriteLine("x is {0} -- In Default case", x);
                        break;
                }
            }

            int x = 0;
            while (true)
            {
                x++;
                if (x >= 3)
                    break;
            }

            for (int x = 0; x < 5; x++)
            {
                if (x < 3)
                    continue;
                Console.WriteLine("Value of x is {0}", x);
            }

            int x = 0;
            while (x < 5)
            {
                if (x < 3)
                {
                    x++;
                    continue;
                }

                Console.WriteLine("Value of x is {0}", x);
                x++;
            }

            bool thingsAreFine;
            while(true)
            {
                thingsAreFine = GetNuclearReactorCondition();

                if (thingsAreFine)
                    Console.WriteLine("Things are fine.");
                else
                    goto NotSoGood;
            }

            NotSoGood: Console.WriteLine("we have a problem.");
        }

    }
}