using System;

namespace Demo
{
    // class MyClass
    // {
    // int[,,] firstArray;
    // int[,] arr1;
    // long[,,] arr3;

    // long[3, 2, 6] SecondArray;  //error 不能在变量声明中指定数组大小
    // int[,,] arr3 = new int[3, 6, 2];

    // int[] arr2 = new int[4];
    // MyClass[] mcaArr = new MyClass[4];

    // static void Main()
    // {
    //     int[] intArr1 = new int[15];
    //     intArr1[2] = 10;
    //     int val1 = intArr1[2];

    //     int[,] intArr2 = new int[5, 10];
    //     intArr2[2, 3] = 7;
    //     int var2 = intArr2[2, 3];

    //     int[] myIntArray;

    //     myIntArray = new int[4];

    //     for (int i = 0; i < 4; i++)
    //         myIntArray[i] = i * 10;

    //     for (int i = 0; i < 4; i++)
    //         Console.WriteLine("Value of element{0} = {1}", i, myIntArray[i]);

    // }

    // static void Main()
    // {
    //     int[] intArr = new int[] { 10, 20, 30, 40 };

    //     int[,] intArray2 = new int[,] { { 10, 1 }, { 2, 10 }, { 11, 9 } };

    //     int[,,] intArray = new int[4, 3, 2] {
    //     {{8,6}, {5,2},{12,9}},
    //     {{6,4}, {13,9},{18,4}},
    //     {{7,2},{1,13},{9,3}},
    //     {{4,6}, {3,2},{23,8}}
    //     };

    //     int[] arr1 = new int[3] { 10, 20, 30 };
    //     int[] arr1 = { 10, 20, 30 };

    //     int[,] arr = new int[2, 3] { { 0, 1, 2 }, { 10, 11, 12 } };
    //     int[,] arr = { { 0, 1, 2 }, { 10, 11, 12 } };

    //     int[] intArr1 = new int[] { 10, 20, 30, 40 };
    //     var intArr2 = new[] { 10, 20, 30, 40 };

    //     int[,] intArr3 = new int[,] { { 10, 1 }, { 2, 10 }, { 11, 9 } };
    //     var intArr4 = new[,] { { 10, 1 }, { 2, 10 }, { 11, 9 } };

    //     string[] sArr1 = new string[] { "life", "liberty", "pursuit of happiness" };
    //     var sArr2 = new[] { "life", "libery", "pursuit of happiness" };


    //     var arr = new int[,] { { 0, 1, 2 }, { 10, 11, 12 } };

    //     for (int i = 0; i < 2; i++)
    //         for (int j = 0; j < 3; j++)
    //             Console.WriteLine("Element [{0}, {1}] is {2}", i, j, arr[i, j]);
    // }

    //     static void Main()
    //     {
    //         int[][] SomeArr;
    //         int[][][] OtherArr;

    //         int[][] jagArr = new int[3][];

    //         int[][] jagArr = new int[3][4]; //error

    //         int[][] Arr = new int[3][];

    //         Arr[0] = new int[] { 10, 20, 30 };
    //         Arr[1] = new int[] { 40, 50, 60, 70 };
    //         Arr[2] = new int[] { 80, 90, 100, 110, 120 };

    //         int[][,] Arr;
    //         Arr = new int[3][,];

    //         Arr[0] = new int[,] { { 10, 20 }, { 100, 200 } };
    //         Arr[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
    //         Arr[2] = new int[,] { { 60, 70, 80, 90 }, { 600, 700, 800, 900 } };

    //         for (int i = 0; i < Arr.GetLength(0); i++)
    //         {
    //             for (int j = 0; j < Arr[i].GetLength(0); j++)
    //             {
    //                 for (int k = 0; k < Arr[i].GetLength(1); k++)
    //                     Console.WriteLine("[{0}][{1},{2}] = {3}", i, j, k, Arr[i][j, k]);
    //             }
    //             Console.WriteLine("");
    //         }
    //         Console.WriteLine("");

    //         int[] arr1 = { 10, 11, 12, 13 };

    //         foreach(int item in arr1)
    //             Console.WriteLine("Item Value: {0}", item);

    //         foreach (int item in arr1)
    //             item++;     //error
    //     }
    // }

    // class MyClass
    // {
    //     public int MyField = 0;
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyClass[] mcArray = new MyClass[4];
    //         for (int i = 0; i < 4; i++)
    //         {
    //             mcArray[i] = new MyClass();
    //             mcArray[i].MyField = i;
    //         }
    //         foreach(MyClass item in mcArray)
    //             item.MyField += 10;

    //         foreach(MyClass item in mcArray)
    //             Console.WriteLine("{0}", item.MyField);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         int total = 0;
    //         int[,] arr1 = { { 10, 11 }, { 12, 13 } };

    //         foreach(var element in arr1)
    //         {
    //             total += element;
    //             Console.WriteLine("Element: {0}, Current Total: {1}", element, total);
    //         }
    //     }
    // }

    // class Progarm
    // {
    //     static void Main()
    //     {
    //         int total = 0;
    //         int[][] arr1 = new int[2][];
    //         arr1[0] = new int[] { 10, 11 };
    //         arr1[1] = new int[] { 12, 13, 14 };

    //         foreach(int[] array in arr1)
    //         {
    //             Console.WriteLine("Starting new array");
    //             foreach(int item in array)
    //             {
    //                 total += item;
    //                 Console.WriteLine("  Item: {0}, Current Total: {1}", item, total);
    //             }
    //         }
    //     }
    // }

    /* class A { }
    class B : A { }

    class Program
    {
        static void Main()
        {
            A[] AArray1 = new A[3];
            A[] AArray2 = new A[3];

            AArray1[0] = new A();
            AArray1[1] = new A();
            AArray1[2] = new A();

            AArray2[0] = new B();
            AArray2[1] = new B();
            AArray2[2] = new B();
        }
    } */

    // class Program
    // {
    //     public static void PrintArray(int[] a)
    //     {
    //         foreach(var x in a)
    //             Console.WriteLine("{0} ", x);
    //         Console.WriteLine("");
    //     }

    //     static void Main()
    //     {
    //         int[] arr = new int[] { 15, 20, 5, 25, 10 };
    //         PrintArray(arr);

    //         Array.Sort(arr);
    //         PrintArray(arr);

    //         Array.Reverse(arr);
    //         PrintArray(arr);

    //         Console.WriteLine();
    //         Console.WriteLine("Rank = {0}, Length = {1}", arr.Rank, arr.Length);
    //         Console.WriteLine("GetLength(0) = {0}", arr.GetLength(0));
    //         Console.WriteLine("GetType() = {0}", arr.GetType());
    //     }
    // }

    // class Clone
    // {
    //     static void Main()
    //     {
    //         int[] intArr1 = { 1, 2, 3 };
    //         int[] intArr2 = (int[])intArr1.Clone();

    //         intArr2[0] = 100;
    //         intArr2[1] = 200;
    //         intArr2[2] = 300;
    //     }
    // }

    class A
    {
        public int Value = 5;
    }

    class Program
    {
        static void Main()
        {
            A[] AArray1 = new A[3] { new A(), new A(), new A() };
            A[] AArray2 = (A[])AArray1.Clone();

            AArray2[0].Value = 100;
            AArray2[1].Value = 200;
            AArray2[2].Value = 300;
        }
    }
}