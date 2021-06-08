using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Console_Telephone_App
{
    class Contacts
    {
        public static List<Person> contactList;


        static Contacts()
        {
            contactList = ExistUsers();

        }

        public static List<Person> ExistUsers()
        {
            return new List<Person>()
            {
                new Person("Elon", "Musk" ,12345),
                new Person("Damiano", "David", 34567),
                new Person("Joey", "Tribbiani", 56789),
                new Person("Regina", "Phalange", 13579),
                new Person("Chandler", "Bing", 24680)
            };

        }


    }
}
