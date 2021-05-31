using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylists can contain many types and can be rearranged the size dynamically
            //System.Collections namespace

            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add("Bahar");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            //Accessing the variables
            Console.WriteLine(list[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("AddRange Method:");
            string[] colors = { "Red", "Yellow", "Green" };
            List<int> numbers = new List<int>() { 1, 8, 3, 7, 13, 67 };

            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("Sort Method:");
            list.Sort(); //may cause the runtime error!!!
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("BinarySearch Method:");
            Console.WriteLine(list.BinarySearch(8));

            //Reverse
            Console.WriteLine("Reverse Method:");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("Clear Method:");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }




        }
    }
}
