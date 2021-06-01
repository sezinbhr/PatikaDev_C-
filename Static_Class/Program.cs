using System;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee number: {0}", Employee.EmployeeNum1);

            Employee employee = new Employee("Ayşe", "Yılmaz", "HR");
            Console.WriteLine("Employee number: {0}", Employee.EmployeeNum1);
            Employee employee1 = new Employee("Atlas", "Rüzgar", "Marketing");
            Employee employee2 = new Employee("Hasan", "Koçak", "IT");

            Console.WriteLine("Employee number: {0}", Employee.EmployeeNum1);

            //Can be accessed the member of the static class with the class name!
            //Static classes can not be inherited
            Console.WriteLine("Result of the sum: {0}", Operations.Sum(100, 200));
            Console.WriteLine("Result of the sub: {0}", Operations.Sub(100, 200));

        }
    }

    class Employee
    {
        private static int EmployeeNum;

        public static int EmployeeNum1 { get => EmployeeNum; }

        private string Name;
        private string SurName;
        private string Department;

        //static constructors have no access modifiers!
        static Employee()
        {
            EmployeeNum = 0;

        }

        public Employee(string name, string surName, string department)
        {
            this.Name = name;
            this.SurName = surName;
            this.Department = department;
            EmployeeNum++;
        }
    }

    static class Operations
    {
        public static long Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
