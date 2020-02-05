#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace IsOperator
{
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status{ get; set; }
    }

    // 新接口
    interface ICompressible
    {
        void Compress();
        void Decompress();
    }

    // Document实现了IStorable
    public class Document : IStorable
    {
        private int status = 0;
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        public void Read()
        {
            Console.WriteLine("Reading...");
        }

        public void Write(object o)
        {
            Console.WriteLine("Writing...");
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }

    // 派生自Document和实现Icompressible
    public class CompressibleDocument : Document, ICompressible
    {
        public CompressibleDocument(String s):
        base(s)
        { }

        public void Compress()
        {
            Console.WriteLine("Compressing...");
        }

        public void Decompress()
        {
            Console.WriteLine("Decompressing...");
        }
    }

    public class Tester
    {
        static void Main()
        {
            // 一组Document
            Document[] docArray = new Document[2];

            docArray[0] = new Document("Test Document");

            docArray[1] = new CompressibleDocument("Test compressibleDocument");

            foreach(Document doc in docArray)
            {
                Console.WriteLine("Got: {0}", doc);

                // if (doc is IStorable)
                // {
                //     IStorable isDoc = (IStorable)doc;
                //     isDoc.Read();
                // }

                // if (doc is ICompressible)
                // {
                //     ICompressible icDoc = (ICompressible)doc;
                //     icDoc.Compress();
                // }

                IStorable isDoc = doc as IStorable;
                if (isDoc != null)
                {
                    isDoc.Read();
                }

                IComparable isDoc = doc as ICompressible;
                if (icDoc != null)
                {
                    icDoc.Compress();
                }
            }
        }
    }
}