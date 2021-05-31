using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n number of positive numbers:");
            string n = Console.ReadLine();
            Question1 question1 = new Question1();
            int arrlen = question1.PositiveCheck(n);
            question1.GetArray(arrlen);

        }
    }

    public class Question1
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
        public void GetArray(int n)

        {
            int[] numArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the array:", i + 1);
                numArr[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num in numArr)
            {
                if (num % 2 == 0)
                {
                    Console.Write("Even numbers:" + num + " ");
                }
            }

        }

    }
}