namespace Programming_CSharp
{
    public class Employee
    {
        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        }
        private int empID;
    }

    public class Tester
    {
        static void Main()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                System.Console.WriteLine(intArray[i].ToString());
            }

            for (int i = 0; i < empArray.Length; i++)
            {
                System.Console.WriteLine(empArray[i].ToString());
            }
        }
    }
}