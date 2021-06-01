using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes are reference type; int,long,char types are value types.
            //Reference types are executed in the heap memory
            Rectangle rectangle = new Rectangle();
            rectangle.shortAngle = 4;
            rectangle.longAngle = 5;
            Console.WriteLine("Class area calculation :{0}", rectangle.CalculateArea());

            Rectangle_Struct rectangle_struct = new Rectangle_Struct(4, 5);
            Console.WriteLine("Struct area calculation :{0}", rectangle_struct.CalculateArea());


        }
    }

    class Rectangle
    {
        public int shortAngle;
        public int longAngle;

        public long CalculateArea()
        {
            return this.shortAngle * this.longAngle;
        }
    }

    struct Rectangle_Struct
    {
        public int shortAngle;
        public int longAngle;
        public long CalculateArea()
        {
            return this.shortAngle * this.longAngle;
        }

        //The constructor of the struct must be written with parameters!

        public Rectangle_Struct(int shortAngle, int longAngle)
        {
            this.shortAngle = shortAngle;
            this.longAngle = longAngle;
        }

    }
}
