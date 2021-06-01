using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name1 = "Bahar";
            student.Surname1 = "Sezin";
            student.StuId1 = 12345;
            student.Class1 = 3;
            student.GetStudentInfo();

            student.ExtraCredit();
            student.GetStudentInfo();

            Student student1 = new Student("Deniz", "Arda", 256, 1);
            student1.GetStudentInfo();
            student1.LowCredit();
            student1.LowCredit();


        }
    }

    class Student
    {
        private string Name;
        private string Surname;
        private int StuId;
        private int Class;

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public int StuId1 { get => StuId; set => StuId = value; }
        public int Class1
        {
            get => Class;
            set
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Class number can not be less than 1");
                    Class = 1;
                }
                else
                {
                    Class = value;
                }

            }
        }


        //constructor method overloading
        public Student(string name1, string surname1, int stuId1, int class1)
        {
            Name1 = name1;
            Surname1 = surname1;
            StuId1 = stuId1;
            Class1 = class1;
        }
        public Student() { }

        public void GetStudentInfo()
        {
            System.Console.WriteLine("Students Info:");
            System.Console.WriteLine("Student name    :{0}", this.Name1);
            System.Console.WriteLine("Student Surname    :{0}", this.Surname1);
            System.Console.WriteLine("Student No    :{0}", this.StuId1);
            System.Console.WriteLine("Student Class    :{0}", this.Class1);

        }

        public void ExtraCredit()
        {
            this.Class1 = this.Class1 + 1;

        }
        public void LowCredit()
        {
            this.Class1 = this.Class1 - 1;

        }
    }
}
