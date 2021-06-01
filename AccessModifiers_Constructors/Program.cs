using System;

namespace AccessModifiers_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Pınar", "Yılmaz", 12345, "Business Intelligence");

            emp1.EmployeeInfo();

            Employee emp2 = new Employee();
            emp2.Name = "Deniz";
            emp2.Surname = "Arda";
            emp2.No = 12346;
            emp2.Department = "HR";

            emp2.EmployeeInfo();

            Employee emp3 = new Employee("Atlas", "Rüzgar");

            emp3.EmployeeInfo();

        }
    }

    class Employee
    {
        //properties
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee(string name, string surname, int no, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee()
        {

        }
        public void EmployeeInfo()
        {
            Console.WriteLine("Employee's name:{0}", Name);
            Console.WriteLine("Employee's surname:{0}", Surname);
            Console.WriteLine("Employee's No:{0}", No);
            Console.WriteLine("Employee's Department:{0}", Department);

        }
    }
}

