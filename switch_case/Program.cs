using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression (between)
            switch (month)
            {
                case 1:
                    Console.WriteLine("It's January!");
                    break;
                case 2:
                    Console.WriteLine("It's February!");
                    break;
                case 4:
                    Console.WriteLine("It's April!");
                    break;
                case 3:
                    Console.WriteLine("It's March!");
                    break;

                default:
                    System.Console.WriteLine("Check it out! You entered a wrong value!");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("It's winter season!");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("It's spring season!");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("It's summer season!");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("It's autumn season!");
                    break;

                default:
                    break;
            }
        }
    }
}
