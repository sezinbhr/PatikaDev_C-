using System;
using System.Collections.Generic;

namespace generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class;
            //System.Collections.Generic;
            // T-> object type

            List<int> numList = new List<int>();
            numList.Add(23);
            numList.Add(10);
            numList.Add(4);
            numList.Add(92);
            numList.Add(5);
            numList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            //Count
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

            //foreach and List.Foreach using
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            //Remove an element from the list
            numList.Remove(4);
            colorList.Remove("Green");

            numList.RemoveAt(1);
            colorList.RemoveAt(0);

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            //Searching in the list
            if (numList.Contains(23))
            {
                System.Console.WriteLine("It's found in the list!");
            }

            //Accessing the index with an element
            Console.WriteLine(colorList.BinarySearch("Yellow"));

            //Conversion the array to the list
            string[] animals = { "Cat", "Dog", "Bird" };
            List<String> animalList = new List<string>(animals);

            //Clear the list
            animalList.Clear();

            //List and object types
            List<Users> userList = new List<Users>();

            Users user = new Users();
            user.Name1 = "Elon";
            user.Surname1 = "Musk";
            user.Age = 49;

            Users user1 = new Users();
            user1.Name1 = "Damiano";
            user1.Surname1 = "David";
            user1.Age = 21;

            userList.Add(user);
            userList.Add(user1);

            List<Users> newUserList = new List<Users>();
            newUserList.Add(new Users()
            {
                Name1 = "Freddie",
                Surname1 = "Mercury",
                Age = 32
            });

            foreach (var userS in userList)
            {
                Console.WriteLine("User Name: " + userS.Name1);
                Console.WriteLine("User Surname: " + userS.Surname1);
                Console.WriteLine("User Age: " + userS.Age);
            }

            newUserList.Clear();

        }
    }

    public class Users
    {
        private string Name;
        private string Surname;
        private int age;

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
