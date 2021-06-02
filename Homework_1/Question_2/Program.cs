using System;
using System.Collections.Generic;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question2 question2 = new Question2();
            Console.WriteLine("Please enter two positive numbers:");
            Console.WriteLine("Enter the number of n:");
            string n = Console.ReadLine();
            int arrlen = question2.PositiveCheck(n);
            Console.WriteLine("Enter the number of m:");
            string m = Console.ReadLine();
            int num = question2.PositiveCheck(m);
            question2.GetArray(arrlen, num);

        }
    }
    public class Question2
    {
        public int PositiveCheck(string number)
        {
            try
            {
                int n = Int32.Parse(number);

                if (n <= 0)
                {
                    Console.WriteLine("You entered an invalid value, enter a valid value!");
                    number = Console.ReadLine();
                    return PositiveCheck(number);
                }

                return n;
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered an invalid value, enter a valid value!");
                number = Console.ReadLine();
                return PositiveCheck(number);
            }
        }
        public void GetArray(int n, int m)

        {
            Question2 question2 = new Question2();
            List<int> numList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the array:", i + 1);
                string number = Console.ReadLine();
                numList.Add(question2.PositiveCheck(number));

            }

            foreach (var num in numList)
            {
                if (num % m == 0 || num == m)
                {
                    Console.Write("The numbers:" + num + " ");
                }
            }

        }

    }
}
