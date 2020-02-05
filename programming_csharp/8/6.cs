#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace ReferencesOnValueTypes
{
    interface IStorable
    {
        void Read();
        int Status{ get; set; }
    }

    public struct myStruct : IStorable
    {
        public void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }

        public int Status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }
        private int Status;
    }

    public class Tester
    {
        static void Main()
        {
            myStruct theStruce = new myStruct();
            theStruce.Status = -1;
            Console.WriteLine("theStruce.Status: {0}", theStruce.Status);

            theStruce.Status = 2;
            Console.WriteLine("Changed object.");
            Console.WriteLine("theStruct.Status: {0}", theStruce.Status);

            IStorable isTemp = (IStorable)theStruce;

            isTemp.Status = 4;
            Console.WriteLine("Changed interface.");
            Console.WriteLine("theStruct.Status: {0}, isTemp: {1}", theStruce.Status, isTemp.Status);

            theStruce.Status = 6;
            Console.WriteLine("Changed object.");
            Console.WriteLine("theStruct.Status: {0}, isTemp: {1}", theStruce.Status, isTemp.Status);
        }
    }
}