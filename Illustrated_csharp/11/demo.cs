using System;

namespace Demo
{
    // class Program
    // {
    // enum TrafficLight : int
    // {
    //     Green,
    //     Yellow,
    //     Red
    // }

    // enum CardSuit
    // {
    //     Hearts, //0
    //     Clubs,  //1
    //     Diaminds,   //2
    //     Spades,     //3
    //     MaxSuits    //4
    // }

    // enum FaceCards
    // {
    //     Jack = 11,      //11
    //     Queen,          //12
    //     King,           //13
    //     Ace,            //14
    //     NumberOfFaceCards = 4,  //4
    //     SomeOtherValue,     //5
    //     HighestFaceCard = Ace   //14
    // }


    // static void Main()
    // {
    //     TrafficLight t1 = TrafficLight.Green;
    //     TrafficLight t2 = TrafficLight.Yellow;
    //     TrafficLight t3 = TrafficLight.Red;
    //     Console.WriteLine("{0},\t{1}", t1, (int)t1);
    //     Console.WriteLine("{0},\t{1}", t2, (int)t2);
    //     Console.WriteLine("{0},\t{1}\n", t3, (int)t3);

    //     TrafficLight t1 = TrafficLight.Red;
    //     TrafficLight t2 = TrafficLight.Green;
    //     TrafficLight t3 = t2;

    //     Console.WriteLine(t1);
    //     Console.WriteLine(t2);
    //     Console.WriteLine(t3);
    // }

    // [Flags]
    // enum CardDeckSettings : uint
    // {
    //     SingleDeck = 0x01,
    //     LargePictures = 0x02,
    //     FancyNumbers = 0x04,
    //     Animation = 0x08,
    // }

    // static void Main()
    // {
    //     CardDeckSettings ops = CardDeckSettings.SingleDeck | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;

    //     bool useFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);

    //     CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;

    //     bool useAnimationAndFancyNumbers = ops.HasFlag(testFlags);

    //     bool useFancyNumbers = (ops & CardDeckSettings.FancyNumbers) == CardDeckSettings.FancyNumbers;
    // }


    // }
    // enum CardDeckSettings : uint
    // {
    //     SingleDeck = 0x01,
    //     LargePictures = 0x02,
    //     FancyNumbers = 0x04,
    //     Animation = 0x08
    // }
    // class Program
    // {

    //     static void Main()
    //     {
    //         CardDeckSettings ops;
    //         ops = CardDeckSettings.FancyNumbers;
    //         Console.WriteLine(ops.ToString());

    //         ops = CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
    //         Console.WriteLine(ops.ToString());
    //     }
    // }

    // [Flags]
    // enum CardDeckSettings : uint
    // {
    //     SingleDeck = 0x01,
    //     LargePictures = 0x02,
    //     FancyNumbers = 0x04,
    //     Animation = 0x08
    // }

    // class MyClass
    // {
    //     bool UseSingleDeck = false,
    //     UseBigPics = false,
    //     UseFancyNumbers = false,
    //     UseAnimation = false,
    //     useAnimationAndFancyNumbers = false;

    //     public void SetOptions(CardDeckSettings ops)
    //     {
    //         UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
    //         UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
    //         UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
    //         UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

    //         CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
    //         useAnimationAndFancyNumbers = ops.HasFlag(testFlags);
    //     }

    //     public void PrintOptions()
    //     {
    //         Console.WriteLine("Option settings:");
    //         Console.WriteLine("     Use Single Deck     - {0}", UseSingleDeck);
    //         Console.WriteLine("     Use Large Pictures  - {0}", UseBigPics);
    //         Console.WriteLine("     Use Fancy Numbers   - {0}", UseFancyNumbers);
    //         Console.WriteLine("     Show Animation      - {0}", UseAnimation);
    //         Console.WriteLine("     Show Animation and FancNumbers - {0}", useAnimationAndFancyNumbers);
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         MyClass mc = new MyClass();
    //         CardDeckSettings ops = CardDeckSettings.SingleDeck | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;

    //         mc.SetOptions(ops);
    //         mc.PrintOptions();
    //     }
    // }

    // enum FirstEnum
    // {
    //     Mem1,
    //     Mem2
    // }

    // enum SecondEnum
    // {
    //     Mem1,
    //     Mem2
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         if (FirstEnum.Mem1 < FirstEnum.Mem2)
    //             Console.WriteLine("True");

    //         if (FirstEnum.Mem1 < SecondEnum.Mem1)   // error
    //             Console.WriteLine("True");
    //     }
    // }

    enum TrafficLight
    {
        Green,
        Yellow,
        Red
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Second member of TrafficLight is {0}\n",
            Enum.GetName(typeof(TrafficLight), 1));

            foreach (var name in Enum.GetName(typeof(TrafficLight)))
                Console.WriteLine(name);
        }
    }
}