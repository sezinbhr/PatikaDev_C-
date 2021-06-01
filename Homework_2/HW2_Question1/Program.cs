using System;
using System.Collections.Generic;

namespace HW2_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 20 positive numbers:");
            Question1 question1 = new Question1();
            List<int> numList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter the value of {0}. number of the array:", i + 1);
                string number = Console.ReadLine();
                numList.Add(question1.PositiveCheck(number));

            }

            List<int> primeNum = new List<int>();
            List<int> notPrimeNum = new List<int>();

            foreach (var n in numList)
            {
                if (n.Check_IsPrime())
                {
                    primeNum.Add(n);
                }
                else
                {
                    notPrimeNum.Add(n);
                }

            }

            primeNum.Reverse();
            foreach (var prime in primeNum)
            {
                Console.WriteLine("Prime Numbers reverse sorted:" + prime);

            }

            notPrimeNum.Reverse();
            foreach (var nonPrime in notPrimeNum)
            {
                Console.WriteLine("Non Prime Numbers reverse sorted:" + nonPrime);
            }

            Console.WriteLine("The number of prime numbers:" + primeNum.Count);
            Console.WriteLine("The number of non-prime numbers:" + notPrimeNum.Count);

            Console.WriteLine("The average of prime numbers:" + notPrimeNum.get_Average());
            Console.WriteLine("The average of non-prime numbers:" + notPrimeNum.get_Average());
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

    }
    public static class Extension //extension class and methods have to be static 
    {
        static bool IsPrime = true;

        public static bool Check_IsPrime(this int n)
        {
            // corner cases
            if ((n & 1) == 0)
            {
                if (n == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= n; i += 2)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }
            return n != 1;
        }

        public static int get_Average(this List<int> param)
        {
            int sum = 0;
            for (var i = 0; i < param.Count; i++)
            {
                sum += param[i];
            }
            return (sum / param.Count);
        }

    }
}


