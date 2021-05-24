using System;

namespace if_else_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Good morning!");
            }

            else if (time <= 18)
            {
                Console.WriteLine("Have a nice day!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

            string sonuc = time <= 18 ? "Have a nice day!" : "Good Night!"; //if statement shortcut version
            sonuc = time >= 6 && time < 11 ? "Good Morning!" : time <= 18 ? "Have a nice day!" : "Good Night!";

            Console.WriteLine(sonuc);





        }
    }
}
