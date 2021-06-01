using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            //get the numeric value of enum through casting
            Console.WriteLine((int)Days.Saturday);

            int temp = 32;
            if (temp <= (int)weather_forecast.Normal)
            {
                Console.WriteLine("Get a coffee, the weather is still cold");
            }
            else if (temp >= (int)weather_forecast.Hot)
            {
                Console.WriteLine("Get an ice-cream, the weather is hot!");
            }
            else if (temp >= (int)weather_forecast.Hot && temp < (int)weather_forecast.Melted)
            {
                Console.WriteLine("Get dressed and go outside!");

            }

        }
    }

    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 21,
        Saturday,
        Sunday
    }

    enum weather_forecast
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        Melted = 40
    }
}
