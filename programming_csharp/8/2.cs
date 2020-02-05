#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace ExtendAndCombineInterface
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

    // 扩展接口
    interface ILoggedCompressible : ICompressible
    {
        void LogSavedBytes();
    }

    // 组合接口
    interface IStorableCompressible : IStorable, ILoggedCompressible
    {
        void LogOriginalSize();
    }

    // 另一个接口
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }

    public class Document : IStorableCompressible, IEncryptable
    {
        // 保存IStorable的Status属性的数据
        private int status = 0;

        // Document构造方法
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        // 实现IStorable
        public void Read()
        {
            Console.WriteLine("Implementing the Read Method for IStorable");
        }

        public void Write(object o)
        {
            Console.WriteLine("Implementing the Write Method for IStorable");
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

        // 实现ICompressible
        public void Compress()
        {
            Console.WriteLine("Implementing Compress");
        }

        public void Decompress()
        {
            Console.WriteLine("Implementing Decompress");
        }

        // 实现ILoggedCompressible
        public void LogSavedBytes()
        {
            Console.WriteLine("Implementing LogSavedBytes");
        }

        // 实现IStorableCompressible
        public void LogOriginalSize()
        {
            Console.WriteLine("Implementing LogOriginalSize");
        }

        // 实现IEncryptable
        public void Encrypt()
        {
            Console.WriteLine("Implementing Encrypt");
        }

        public void Decrypt()
        {
            Console.WriteLine("Implementing Decrypt");
        }
    }

    public class Tester
    {
        static void Main()
        {
            // 创建Document对象
            Document doc = new Document("Test Document");

            // 将Document转换为各种接口
            IStorable isDoc = doc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }
            else
                Console.WriteLine("IStorable noe supported");

            IComparable icDoc = doc as ICompressible;
            if (icDoc != null)
            {
                icDoc.Compress();
            }
            else
                Console.WriteLine("Compressible not supported");

            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if (ilcDoc != null)
            {
                ilcDoc.LogSavedBytes();
                ilcDoc.Compress();
            }
            else
                Console.WriteLine("LoggedCompressible not supported");

            IStorableCompressible isc = doc as IStorableCompressible;
            if (isc != null)
            {
                isc.LogOriginalSize();
                isc.LogSavedBytes();
                isc.Compress();
                isc.Read();
            }
            else
            {
                Console.WriteLine("StorableCompressible not supported");
            }

            IEncryptable ie = doc as IEncryptable;
            if (ie != null)
            {
                ie.Encrypt();
            }
            else
                Console.WriteLine("Encryptable not supported");
        }
    }
}