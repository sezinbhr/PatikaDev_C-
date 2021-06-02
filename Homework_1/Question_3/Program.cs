using System;
using System.Collections.Generic;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Question3 question3 = new Question3();
            Console.WriteLine("Enter the number of n:");
            string n = Console.ReadLine();
            int arrlen = question3.PositiveCheck(n);
            question3.GetReverse(arrlen);
        }
    }

    public class Question3
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
        public void GetReverse(int n)

        {
            Question3 question3 = new Question3();
            List<string> WordList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the word:", i + 1);
                string word = Console.ReadLine();
                WordList.Add(word);
            }
            WordList.Reverse();

            WordList.ForEach(word => Console.WriteLine(word));

        }

    }
}
