using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array 
            string[] colors = new string[5];

            string[] animals = { "cat", "dog", "sheep", "elephant" };

            int[] dizi;
            dizi = new int[5];

            //Assigned a value to arrays

            colors[0] = "blue";
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(animals[1]);
            Console.WriteLine(colors[0]);

            //Array using in the loops
            //Calculate the average by given number n, values will taken from user
            Console.WriteLine("Enter the size of the array:");
            int arrLeng = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLeng];

            for (int i = 0; i < arrLeng; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the array:", i + 1);
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var num in numArr)
            {
                sum += num;
            }

            Console.WriteLine("The average of the numbers:" + sum / arrLeng);

        }
    }
}