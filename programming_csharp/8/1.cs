#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace SimpleInterface
{
    // 声明接口
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int status{ get; set; }
    }

    // 创建实现IStorable接口的类
    public class Document : IStorable
    {
        // 存储属性的值
        private int status = 0;

        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        // 实现Read方法
        public void Read()
        {
            Console.WriteLine("Inplementing the Read Method for IStorable");
        }

        // 实现Write方法
        public void Write(object o)
        {
            Console.WriteLine("Implementing the Write Method for IStorable");
        }

        // 实现属性
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

    // 测试接口
    public class Tester
    {
        static void Main()
        {
            // 访问Document对象中的方法
            Document doc = new Document("Test Document");
            doc.Status = -1;
            doc.Read();
            Console.WriteLine("Document Status: {0}", doc.Status);
        }
    }
}