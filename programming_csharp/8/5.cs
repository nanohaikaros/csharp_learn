#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace ExplicitImplementation
{
    interface IStorable
    {
        void Read();
        void Write();
    }

    interface ITalk
    {
        void Talk();
        void Read();
    }

    public class Document : IStorable, ITalk
    {
        public Document(string s)
        {
            Console.WriteLine("Creating document with:{0}", s);
        }

        public virtual void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }

        public void Write()
        {
            Console.WriteLine("Timplementing IStorable.Write");
        }

        void ITalk.Read()
        {
            Console.WriteLine("Implementing ITalk.Read");
        }

        public void Talk()
        {
            Console.WriteLine("Implementing ITalk.Talk");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Document theDoc = new Document("Test Document");
            IStorable isDoc = theDoc;
            isDoc.Read();

            ITalk itDoc = theDoc;
            itDoc.Read();

            theDoc.Read();
            theDoc.Talk();
        }
    }
}