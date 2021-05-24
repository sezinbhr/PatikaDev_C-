using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While 
            //Starting from 1 compute the average until the given number
            Console.WriteLine("Enter a number:");
            int counter = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= counter)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("The average is:" + sum / counter);

            //Starting from 'a' to 'z' write all the letters to the console
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;

            }

            //Foreach
            string[] cars = { "BMW", "Audi", "Porsche" };

            foreach (var car in cars) //var is a generic type 
            {
                Console.WriteLine(car);
            }
        }
    }
}
