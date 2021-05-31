using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "The course is C#";
            string variable2 = "The course is Java";
            string variable3 = "the course is C#";
            //length
            Console.WriteLine(variable.Length);

            //ToUpper-ToLower
            Console.WriteLine(variable.ToLower());
            Console.WriteLine(variable.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(variable, " Hello!!"));

            //Compare, CompareTo; return these values => {-1,1,0}
            Console.WriteLine(variable.CompareTo(variable2));
            Console.WriteLine(String.Compare(variable, variable3, true));
            Console.WriteLine(String.Compare(variable, variable3, false));

            //Contains
            Console.WriteLine(variable.Contains(variable3));
            Console.WriteLine(variable.EndsWith("C#"));
            Console.WriteLine(variable.StartsWith("The"));

            //IndexOf
            Console.WriteLine(variable.IndexOf("C#"));
            Console.WriteLine(variable.IndexOf("J#"));
            Console.WriteLine(variable.LastIndexOf("i"));

            //Insert
            Console.WriteLine(variable.Insert(0, "Welcome! "));

            //PadLeft, PadRight
            Console.WriteLine(variable2 + variable.PadLeft(30));
            Console.WriteLine(variable2 + variable.PadLeft(30, '*'));
            Console.WriteLine(variable2.PadRight(50) + variable);
            Console.WriteLine(variable2.PadRight(50, '-') + variable);

            //Remove
            Console.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(5, 3));
            Console.WriteLine(variable.Remove(0, 1));

            //Replace
            Console.WriteLine(variable.Replace("C#", "CSHarp"));
            Console.WriteLine(variable.Replace(" ", "-"));

            //Split
            Console.WriteLine(variable.Split(' ')[1]);

            //Substring
            Console.WriteLine(variable.Substring(4));
            Console.WriteLine(variable.Substring(4, 6));






        }
    }
}
