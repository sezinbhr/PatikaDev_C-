using System;
using System.Collections;
namespace Console_Telephone_App
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int tel_Num { get; set; }

        public Person(string firstName, string lastName, int tel_num)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.tel_Num = tel_num;
        }
    }
}