#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace ListCollection
{
    public class Employee
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        }

        public int empID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
    }

    public class Tester
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();
            List<int> intList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                empList.Add(new Employee(i + 100));
                intList.Add(i * 5);
            }

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }

            Console.WriteLine("\n");
            Console.WriteLine("empList.Capacity: {0}", empList.Capacity);
        }
    }
}