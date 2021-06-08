using System;


namespace Console_Telephone_App
{
    class UserAction
    {
        public void AddContact(Person person)
        {
            Contacts.contactList.Add(person);
            Console.WriteLine("The person was added successfully!");
        }

        public void DeleteNumber(string cont_name)
        {
            Console.WriteLine();
            int i = 0;
            foreach (var cont in Contacts.contactList)
            {
                if (cont_name.ToLower().Equals(cont.LastName.ToLower()) || cont_name.ToLower().Equals(cont.FirstName.ToLower()))

                {
                    i++;
                    Console.WriteLine("The person named {0} will be deleted from the contact list, do you confirm? (y/Y/n/N", cont_name);
                    string option = Console.ReadLine();
                    if (option.ToLower() == "y" || option.ToUpper() == "Y")
                    {
                        Contacts.contactList.Remove(cont);
                        Console.WriteLine("Deletion completed successfully!");
                        break;
                    }
                    else if (option.ToLower() == "n" || option.ToUpper() == "N")
                    {
                        Console.WriteLine("You can go back to main menu");
                        break;
                    }

                }
                if (i == 0)
                {
                    Console.WriteLine("No results found. Please make a selection:");
                    Console.WriteLine("To complete the deletion: (1)");
                    Console.WriteLine("To try again: (2)");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 2)
                    {
                        Program.delete_info();
                    }
                }
            }

        }
        public void Update_cont_Num(string cont_name)
        {
            Console.WriteLine();
            int i = 0;
            foreach (var cont in Contacts.contactList)
            {
                if (cont_name.ToLower().Equals(cont.LastName.ToLower()) || cont_name.ToLower().Equals(cont.FirstName.ToLower()))

                {
                    i++;
                    Console.WriteLine("Please enter a new phone number");
                    int newPhNum = int.Parse(Console.ReadLine());
                    cont.tel_Num = newPhNum;
                    break;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("No results found. Please make a selection:");
                Console.WriteLine("To complete the update: (1)");
                Console.WriteLine("To try again: (2)");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    Program.edit_info();
                }
            }
        }

        public void ViewContactList(int param)
        {
            Console.WriteLine();
            if (param == 1)
            {
                Contacts.contactList.Sort((p1, p2) => p1.FirstName.CompareTo(p2.FirstName));
            }
            else if (param == 2)
            {
                Contacts.contactList.Sort((p1, p2) => p1.FirstName.CompareTo(p2.FirstName));
                Contacts.contactList.Reverse();
            }

            foreach (var cont in Contacts.contactList)
            {
                Console.WriteLine("First name: {0}", cont.FirstName);
                Console.WriteLine("Last name: {0}", cont.LastName);
                Console.WriteLine("Contact number: {0}", cont.tel_Num);
                Console.WriteLine("-");
            }

        }
        public void Search_Contacts(int param)
        {
            Console.WriteLine();
            if (param == 1)
            {
                Console.WriteLine("Enter the name or the last name of the contact:");
                string cont_name = Console.ReadLine();

                Console.WriteLine("The search results:");
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                foreach (var cont in Contacts.contactList)
                {
                    if (cont_name.ToLower().Equals(cont.LastName.ToLower()) || cont_name.ToLower().Equals(cont.FirstName.ToLower()))
                    {
                        Console.WriteLine("First name: {0}", cont.FirstName);
                        Console.WriteLine("Last name: {0}", cont.LastName);
                        Console.WriteLine("Contact number: {0}", cont.tel_Num);
                    }
                }
            }

            else if (param == 2)
            {
                Console.WriteLine("Enter the phone number:");
                int cont_num = int.Parse(Console.ReadLine());

                Console.WriteLine("The search results:");
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                foreach (var cont in Contacts.contactList)
                {
                    if (cont.tel_Num == cont_num)
                    {
                        Console.WriteLine("First name: {0}", cont.FirstName);
                        Console.WriteLine("Last name: {0}", cont.LastName);
                        Console.WriteLine("Contact number: {0}", cont.tel_Num);
                    }
                }
            }
        }
    }
}