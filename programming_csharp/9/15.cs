#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace IComparer
{
    public class Employee : IComparable<Employee>
    {
        private int empID;
        private int yearsOfSvc = 1;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public Employee(int empID, int yearsOfSvc)
        {
            this.empID = empID;
            this.yearsOfSvc = yearsOfSvc;
        }

        public override string ToString()
        {
            return "ID: " + empID.ToString() + ". Years of Svc: " + yearsOfSvc.ToString();
        }

        public bool Equals(Employee other)
        {
            if (this.empID == other.empID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static EmployeeComparer GetComparer()
        {
            return new EmployeeComparer.EmployeeComparer();
        }

        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }

        public int CompareTo(Employee rhs, Employee.EmployeeComparer.ComparisonType which)
        {
            switch (which)
            {
                case Employee.EmployeeComparer.ComparisonType.EmpID:
                    return this.empID.CompareTo(rhs.empID);
                case Employee.EmployeeComparer.ComparisonType.Yrs:
                    return this.yearsOfSvc.CompareTo(rhs.yearsOfSvc);
            }
            return 0;
        }

        public class EmployeeComparer : IComparer<Employee>
        {
            private Employee.EmployeeComparer.ComparisonType whichComparison;
            public enum ComparisonType
            {
                EmpID,
                Yrs
            };

            public bool Equals(Employee lhs, Employee rhs)
            {
                return this.Compare(lhs, rhs) == 0;
            }

            public int GetHashCode(Employee e)
            {
                return e.GetHashCode();
            }

            public int Compare(Employee lhs, Employee rhs)
            {
                return lhs.CompareTo(rhs, whichComparison);
            }

            public Employee.EmployeeComparer.ComparisonType whichComparison
            {
                get { return whichComparison; }
                set { whichComparison = value; }
            }
        }
    }

    public class Tester
    {
        static void Main()
        {
            List<Employee> empArray = new List<Employee>();

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100, r.Next(20)));
            }

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            Employee.EmployeeComparer c = Employee.GetComparer();
            c.whichComparison = Employee.EmployeeComparer.ComparisonType.EmpID;
            empArray.Sort(c);

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            c.whichComparison = Employee.EmployeeComparer.ComparisonType.Yrs;
            empArray.Sort(c);

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
        }
    }
}