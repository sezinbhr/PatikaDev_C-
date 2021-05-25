using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int result = Topla(a, b);
            System.Console.WriteLine(result);

            Methods sample = new Methods(); //must be created an instance, the method which is called is in different class
            sample.WriteTheScreen(Convert.ToString(result));

            int result2 = sample.IncreaseandSum(ref a, ref b);
            sample.WriteTheScreen(Convert.ToString(result2));
            sample.WriteTheScreen(Convert.ToString(a + b));
        }

        static int Topla(int value1, int value2)
        {

            return (value1 + value2);
        }
    }

    class Methods
    {
        public void WriteTheScreen(string data)
        {
            Console.WriteLine(data);
        }

        public int IncreaseandSum(ref int value1, ref int value2) //ref keyword means that any change made to a value that is passed by reference will reflect this change since you are modifying the value at the address and not just the value.
        {
            value1 += 1;
            value2 += 1;
            return (value1 + value2);

        }
    }
}


