using System;

namespace arrayclass_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] nums = { 23, 12, 86, 72, 3, 11, 17 };

            Console.WriteLine("Unsorted array");
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Sorted array");
            Array.Sort(nums);

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //Clear
            Console.WriteLine("Array Clear");
            Array.Clear(nums, 2, 2); //start from 2nd array element and count 2 elements from this index and replace the value with 0

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //Reverse
            Console.WriteLine("Reverse");
            Array.Reverse(nums);

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //IndexOf
            Console.WriteLine("IndexOf");
            System.Console.WriteLine(Array.IndexOf(nums, 23));

            //Resize, adjust the array size
            Console.WriteLine("Resize");
            Array.Resize<int>(ref nums, 9);
            nums[8] = 99;

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }



        }
    }
}
