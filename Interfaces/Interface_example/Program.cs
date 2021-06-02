using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            bmw_x5 bmw_X5 = new bmw_x5();
            Console.WriteLine(bmw_X5.CarBrand().ToString());
            Console.WriteLine(bmw_X5.WheelNumber().ToString());
            Console.WriteLine(bmw_X5.Stacolor().ToString());

            carrera carrera = new carrera();
            Console.WriteLine(carrera.CarBrand().ToString());
            Console.WriteLine(carrera.WheelNumber().ToString());
            Console.WriteLine(carrera.Stacolor().ToString());


        }
    }
}
