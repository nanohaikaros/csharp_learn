#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace JaggedArray
{
    public class Tester
    {
        static void Main()
        {
            const int rows = 4;

            int[][] JaggedArray = new int[rows][];

            JaggedArray[0] = new int[5];

            JaggedArray[1] = new int[2];

            JaggedArray[2] = new int[3];

            JaggedArray[3] = new int[5];

            JaggedArray[0][3] = 15;
            JaggedArray[1][1] = 12;
            JaggedArray[2][1] = 9;
            JaggedArray[2][2] = 99;
            JaggedArray[3][0] = 10;
            JaggedArray[3][1] = 11;
            JaggedArray[3][2] = 12;
            JaggedArray[3][3] = 13;
            JaggedArray[3][4] = 14;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("jaggedArray[0][{0}] = {1}", i, JaggedArray[0][i]);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("jaggedArray[1][{0}] = {1}", i, JaggedArray[1][i]);
            }

            for (int i = 0; i < 3;i++)
            {
                Console.WriteLine("jaggedArray[2][{0}] = {1}", i, JaggedArray[2][i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("jaggedArray[3][{0}] = {1}", i, JaggedArray[3][i]);
            }
        }
    }
}