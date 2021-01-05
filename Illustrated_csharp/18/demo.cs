using System;
using System.Collections;

// class MyClass
// {
// static void main()
// {
//     int[] arr1 = { 10, 11, 12, 13 };
//     foreach (int item in arr1)
//     {
//         Console.WriteLine("Item value: {0}", item);
//     }
// }

//     static void Main()
//     {
//         int[] MyArray = { 10, 11, 12, 13 };

//         IEnumerator ie = MyArray.GetEnumerator();

//         while (ie.MoveNext())
//         {
//             int i = (int)ie.Current;
//             Console.WriteLine("{0}", i);
//         }
//     }
// }

// class MyColors : IEnumerable
// {
//     string[] Colors = { "Red", "Yellow", "Blue" };

//     public IEnumerator GetEnumerator()
//     {
//         return new ColorEnumerator(Colors);
//     }
// }

// class ColorEnumerator : IEnumerator
// {
//     string[] _colors;
//     int _position = -1;

//     public ColorEnumerator(string[] theColors)
//     {
//         _colors = new string[theColors.Length];
//         for (int i = 0; i < theColors.Length; i++)
//             _colors[i] = theColors[i];
//     }

//     public object Current
//     {
//         get
//         {
//             if(_position == -1)
//                 throw new InvalidOperationException();
//             if(_position >= _colors.Length)
//                 throw new InvalidOperationException();

//             return _colors[_position];
//         }
//     }

//     public bool MoveNext()
//     {
//         if(_position < _colors.Length - 1)
//         {
//             _position++;
//             return true;
//         }
//         else
//             return false;
//     }

//     public void Reset()
//     {
//         _position = -1;
//     }
// }

// class Spectrum : IEnumerable
// {
//     string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

//     public IEnumerator GetEnumerator()
//     {
//         return new ColorEnumerator(Colors);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Spectrum spectrum = new Spectrum();
//         foreach(string color in spectrum)
//             Console.WriteLine(color);
//     }
// }


// class MyClass
// {
//     public IEnumerator<string> GetEnumerator()
//     {
//         return BlackAndWhite();
//     }

//     public IEnumerator<string> BlackAndWhite()
//     {
//         yield return "black";
//         yield return "gray";
//         yield return "white";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();

//         foreach(string shade in mc)
//             Console.WriteLine(shade);
//     }
// }


// class MyClass
// {
//     public IEnumerator<string> GetEnumerator()
//     {
//         IEnumerable<string> myEnumerable = BlackAndWhite();
//         return myEnumerable.GetEnumerator();
//     }

//     public IEnumerable<string> BlackAndWhite()
//     {
//         yield return "black";
//         yield return "gray";
//         yield return "white";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyClass mc = new MyClass();

//         foreach(string shade in mc)
//             Console.Write("{0} ", shade);

//         foreach(string shade in mc.BlackAndWhite())
//             Console.WriteLine("{0} ", shade);
//     }
// }


// class Spectrum
// {
//     string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

//     public IEnumerable<string> UVtoIR()
//     {
//         for (int i = 0; i < colors.Length; i++)
//             yield return colors[i];
//     }

//     public IEnumerable<string> IRtoUV()
//     {
//         for (int i = colors.Length - 1; i >= 0; i--)
//             yield return colors[i];
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Spectrum spectrum = new Spectrum();

//         foreach(string color in spectrum.UVtoIR())
//             Console.WriteLine("{0} ", color);
//         Console.WriteLine();

//         foreach(string color in spectrum.IRtoUV())
//             Console.WriteLine("{0} ", color);
//         Console.WriteLine();
//     }
// }


class Spectrum
{
    bool _listFromUVtoIR;

    string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

    public Spectrum(bool listFromUVtoIR)
    {
        _listFromUVtoIR = listFromUVtoIR;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return _listFromUVtoIR ? UVtoIR : IRtoUV;
    }

    public IEnumerator<string> UVtoIR
    {
        get
        {
            for (int i = 0; i < colors.Length; i++)
                yield return colors[i];
        }
    }

    public IEnumerator<string> IRtoUV
    {
        get
        {
            for (int i = colors.Length - 1; i >= 0; i--)
                yield return colors[i];
        }
    }
}

class Prgoram
{
    static void main()
    {
        Spectrum startUV = new Spectrum(true);
        Spectrum startIR = new Spectrum(false);

        foreach(string color in startUV)
            Console.WriteLine("{0} ", color);
        Console.WriteLine();

        foreach(string color in startIR)
            Console.WriteLine("{0} ", color);
        Console.WriteLine();
    }
}