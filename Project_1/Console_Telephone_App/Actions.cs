using System;
using System.Collections;
namespace Console_Telephone_App
{
    public class Actions
    {
        public int PositiveCheck(string number)
        {
            try
            {
                int n = Int32.Parse(number);

                if (n <= 0 && n > 5)
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
}