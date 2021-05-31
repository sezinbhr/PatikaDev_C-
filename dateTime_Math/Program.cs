using System;

namespace dateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(12));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //date
            Console.WriteLine(DateTime.Now.ToString("ddd")); //abbreviation string date
            Console.WriteLine(DateTime.Now.ToString("dddd")); // normal string

            Console.WriteLine(DateTime.Now.ToString("MM")); //like the above examples
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy")); //'21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            //Math Library
            Console.WriteLine("Math Library:");
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.3));
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.3));

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(2, 6));
            Console.WriteLine(Math.Sqrt(256));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3)); //e^3
            Console.WriteLine(Math.Log10(10));































        }
    }
}
