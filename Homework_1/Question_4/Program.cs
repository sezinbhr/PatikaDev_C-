using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence:");
            string str = Console.ReadLine();
            Console.WriteLine("The number of the words of this sentence: " + str.Check_Word());
            Console.WriteLine("The number of the letters of this sentence: " + str.Replace(" ", "").Length);

        }
    }

    public static class Extension
    {
        public static int Check_Word(this string param)
        {
            int i = 0;
            int word = 1;

            while (i <= param.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (param[i] == ' ' || param[i] == '\n' || param[i] == '\t')
                {
                    word++;
                }

                i++;
            }
            return word;
        }
    }
}