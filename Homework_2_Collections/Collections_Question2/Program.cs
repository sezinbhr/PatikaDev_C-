using System;
using System.Collections.Generic;

namespace Collections_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 20 numbers:");
            int[] numList = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the word:", i + 1);
                numList[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(numList);
            int[] minList = numList[0..3];

            Array.Reverse(numList);
            int[] maxList = numList[0..3];


        }
    }
}
