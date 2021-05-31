using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Key,value pairs
            //Keys must be unique
            //System.Collections.Generic
            //Disctionary<KeyType, ValueType> 
            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(10, "Bahar Sezin");
            users.Add(12, "Özcan Yaşar");
            users.Add(14, "Ahmet Yılmaz");
            users.Add(16, "Deniz Arda");

            //Accesing the elements
            Console.WriteLine("Accesing the elements:");
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("Count method:");
            System.Console.WriteLine(users.Count);

            //Contains method
            Console.WriteLine("Contains method:");
            Console.WriteLine(users.ContainsKey(10));
            Console.WriteLine(users.ContainsValue("Bahar Sezin"));

            //Remove
            Console.WriteLine("Remove method:");
            Console.WriteLine(users.Remove(12));
            foreach (var item in users)
            {
                Console.WriteLine(item.Value); //item.Value writes only values to the screen
            }

            //Keys & Values
            Console.WriteLine("Keys:");
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Values:");
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}
