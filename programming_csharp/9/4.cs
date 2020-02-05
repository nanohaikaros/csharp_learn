#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace RectangularArray
{
    public class Tester
    {
        static void Main()
        {
            const int rows = 4;
            const int columns = 3;

            int[,] rectangularArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rectangularArray[i, j] = i + j;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("revrangularArray[{0}, {1}] = {2}", i, j, rectangularArray[i, j]);
                }
            }
        }
    }
}