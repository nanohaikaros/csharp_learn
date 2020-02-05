#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace NestedClasses
{
    public class Fraction
    {
        private int numberator;
        private int denominator;

        public Fraction(int numberator, int denominator)
        {
            this.numberator = numberator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numberator, denominator);
        }

        internal class FractionArtist
        {
            public void Draw(Fraction f)
            {
                Console.WriteLine("Drawing the numberator: {0}", f.numberator);
                Console.WriteLine("Drawing the denominator: {0}", f.denominator);
            }
        }
    }

    public class Tester
    {
        static void Main()
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1: {0}", f1.ToString());
            Fraction.FractionArtist fa = new Fraction.FractionArtist();
            fa.Draw(f1);
        }
    }
}