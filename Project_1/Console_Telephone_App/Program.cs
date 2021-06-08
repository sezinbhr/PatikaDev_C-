using System;
using System.Collections;
namespace Console_Telephone_App
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
            Actions actions = new Actions();
            string n = Console.ReadLine();
            int action = actions.PositiveCheck(n);


            //Expression (between)
            switch (action)
            {
                case 1:
                    enter_info();
                    break;
                case 2:
                    delete_info();
                    break;
                case 3:
                    edit_info();
                    break;
                case 4:
                    show_info();
                    break;
                case 5:
                    search_info();
                    break;
                default:
                    System.Console.WriteLine("Check it out! You entered a wrong value!");
                    break;
            }
        }
        public static void UserInterface()
        {
            Console.WriteLine("Please choose the action you want :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Save a new number");
            Console.WriteLine("(2) Delete the number");
            Console.WriteLine("(3) Update the number");
            Console.WriteLine("(4) To show the contacts");
            Console.WriteLine("(5) To search in the contacts ");


        }

        public static void enter_info()
        {
            Console.WriteLine("Enter the first name of your contact   :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name of your contact    :");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the phone number of your contact :");
            int phnum = int.Parse(Console.ReadLine());

            Person newContact = new Person(fname, lname, phnum);

            UserAction adding = new UserAction();
            adding.AddContact(newContact);
        }

        public static void delete_info()
        {
            Console.WriteLine("Enter the name or surname of the person whose number you want to delete:");
            string removed = Console.ReadLine();

            UserAction removing = new UserAction();
            removing.DeleteNumber(removed);
        }

        public static void edit_info()
        {
            Console.WriteLine("Enter the name or surname of the person whose number you want to update:");
            string updated = Console.ReadLine();

            UserAction updating = new UserAction();
            updating.Update_cont_Num(updated);
        }

        public static void show_info()
        {
            Console.WriteLine("Contact List:");
            Console.WriteLine("To list by A-Z: (1)");
            Console.WriteLine("To list by Z-A: (2)");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************************************");

            UserAction listing = new UserAction();
            listing.ViewContactList(option);

        }

        public static void search_info()
        {
            Console.WriteLine("Select the type you want to search.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("To search by first or last name: (1)");
            Console.WriteLine("To search by phoneNumber: (2)");

            int option = int.Parse(Console.ReadLine());
            UserAction searching = new UserAction();
            searching.Search_Contacts(option);

        }
    }


}
