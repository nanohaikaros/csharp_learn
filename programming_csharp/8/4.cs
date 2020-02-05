#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace overridingInterface
{
    interface IStorable
    {
        void Read();
        void Write();
    }

    public class Document : IStorable
    {
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        public virtual void Read()
        {
            Console.WriteLine("Document Read Method for IStorable");
        }

        public void Write()
        {
            Console.WriteLine("Document Write method for IStorable");
        }
    }

    public class Note : Document
    {
        public Note(string s):
        base(s)
        {
            Console.WriteLine("Creating note with: {0}", s);
        }

        public override void Read()
        {
            Console.WriteLine("Overriding the Read method for Note!");
        }

        public new void Write()
        {
            Console.WriteLine("Implementing the write method for Note!");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Document theNote = new Note("Test Note");
            IStorable isNote = theNote as IStorable;
            if (isNote != null)
            {
                isNote.Read();
                isNote.Write();
            }

            Console.WriteLine("\n");

            theNote.Read();
            theNote.Write();

            Console.WriteLine("\n");

            Note note2 = new Note("Second Test");
            IStorable isNote = note2 as IStorable;
            if (isNote != null)
            {
                isNote2.Read();
                isNote.Write();
            }

            Console.WriteLine("\n");

            note2.Read();
            note2.Write();
        }
    }
}
