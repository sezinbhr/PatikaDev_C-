using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write the odd numbers to the console by the given number
            Console.WriteLine("Enter a number:");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                //commands
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }


            }

            //Write the sum of the even numbers and odd numbers between 1 and 1000

            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += i;
                }
                else
                {
                    sum2 += i;
                }

            }
            Console.WriteLine("The sum of the even numbers:" + sum1);
            Console.WriteLine("The sum of the odd numbers:" + sum2);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
