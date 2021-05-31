using System;

namespace recursive_ext_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive functions
            //3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Operations instance = new Operations();
            result = instance.Expo(3, 1);
            Console.WriteLine(result);

            //Extension Methods
            string expression = "Bahar Sezin";
            bool result2 = expression.CheckSpaces();
            Console.WriteLine(result2);
            if (result2)
            {
                Console.WriteLine(expression.RemoveWhiteSpaces());
            }
            Console.WriteLine(expression.MakeUpperCase());
            Console.WriteLine(expression.MakeLowerCase());

            int[] array = { 14, 2, 3, 9, 6, 7, 11, 13 };
            array.SortArray();
            array.WriteToScreen();

            int number=5;
            Console.WriteLine(number.IfEvenNumber());
            Console.WriteLine(expression.GetFirstCharacter());


        }
    }

    public class Operations
    {
        public int Expo(int number, int exp)
        {
            if (exp < 2)
            {
                return number;
            }
            return Expo(number, exp - 1) * number;
        }
    }

    public static class Extension //extension class and methods have to be static 
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] array = param.Split(" ");
            return string.Join("-", array);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void WriteToScreen(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);
        }

        public static bool IfEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }



    }
}
