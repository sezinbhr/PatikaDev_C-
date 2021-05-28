using System;

namespace methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parameters
            string number = "999";
            int outNumber;

            bool result = int.TryParse(number, out outNumber); //double check for type conversions

            if (result)
            {
                Console.WriteLine("Successful!");
                Console.WriteLine(outNumber);
            }

            else
            {
                Console.WriteLine("Failed!");
            }

            Methods instance = new Methods();
            instance.Sum(4, 5, out int sumResult);
            Console.WriteLine(sumResult);

            //Method overloading

            int exp = 999;
            instance.WriteToScreen(Convert.ToString(exp));
            instance.WriteToScreen(exp);
            instance.WriteToScreen("Bahar", "Sezin");

            //method signature is:
            //method_name + parameter_number + parameter


        }
    }

    class Methods
    {
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }

        public void WriteToScreen(string data)
        {
            Console.WriteLine(data);
        }
        public void WriteToScreen(int data)
        {
            Console.WriteLine(data);
        }
        public void WriteToScreen(string data, string data2)
        {
            Console.WriteLine(data + data2);
        }
    }
}
