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

            Console.WriteLine("The average of the first three minimums in the array: {0}", minList.get_Average());
            Console.WriteLine("The average of the first three maximums in the array: {0}", maxList.get_Average());

            Console.WriteLine("The sum of the first three minimums in the array: {0}", minList.get_Sum());
            Console.WriteLine("The sum of the first three maximums in the array: {0}", maxList.get_Sum());

        }
    }

    public static class Extension //extension class and methods have to be static 
    {

        public static int get_Average(this int[] param)
        {
            int sum = 0;
            for (var i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }
            return (sum / param.Length);
        }
        public static int get_Sum(this int[] param)
        {
            int sum = 0;
            for (var i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }
            return (sum);
        }

    }
}