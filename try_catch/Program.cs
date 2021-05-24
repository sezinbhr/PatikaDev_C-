using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try //the code in the try block may be cause an error
            {
                Console.WriteLine("Enter a number:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is:" + sayi);

            }

            catch (Exception ex) // Let's catch the error, and show/fix what's happened!
            {
                Console.WriteLine("Error:" + ex.Message.ToString());

            }
            //finally // No matter what, I want to run the code which is written in the finally block. It's not mandatory to use
            //{
            //    Console.WriteLine("It's done!");

            //}

            try
            {
                // int a = int.Parse(null);
                //int b = int.Parse("test");
                int c = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)

            {

                Console.WriteLine("You entered a null value!");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Data type couldn't matched!");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You entered a value too big, or too small!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("It's done successfully!");
            }

        }
    }
}
