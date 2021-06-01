using System;

namespace class_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Pınar";
            emp1.Surname = "Yılmaz";
            emp1.No = 12345;
            emp1.Department = "Business Intelligence";

            emp1.EmployeeInfo();

            Employee emp2 = new Employee();
            emp2.Name = "Deniz";
            emp2.Surname = "Arda";
            emp2.No = 12345;
            emp2.Department = "HR";

            emp2.EmployeeInfo();

        }
    }

    class Employee
    {
        //properties
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInfo()
        {
            Console.WriteLine("Employee's name:{0}", Name);
            Console.WriteLine("Employee's surname:{0}", Surname);
            Console.WriteLine("Employee's No:{0}", No);
            Console.WriteLine("Employee's Department:{0}", Department);

        }
    }
}
