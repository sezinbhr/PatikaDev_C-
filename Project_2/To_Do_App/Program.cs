using System;
using System.Collections.Generic;

namespace To_Do_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            members.Add(new Member(1, "Bahar"));
            members.Add(new Member(2, "Pınar"));
            members.Add(new Member(3, "Halil"));
            members.Add(new Member(4, "Oguz"));
            members.Add(new Member(5, "Deniz"));
            members.Add(new Member(6, "Mavi"));

            List<Card> cards = new List<Card>();
            List<Card> ToDo = new List<Card>();
            List<Card> InProgress = new List<Card>();
            List<Card> Done = new List<Card>();

            cards.Add(new Card("French", "language", Size.S, members[1], Type.ToDo));
            cards.Add(new Card("Italian", "language", Size.M, members[0], Type.Done));
            cards.Add(new Card("English", "language", Size.XS, members[2], Type.InProgress));
            cards.Add(new Card("German", "language", Size.XL, members[3], Type.Done));
            cards.Add(new Card("Chinese", "language", Size.XL, members[4], Type.InProgress));

            CardActions cardActions = new CardActions();
            cardActions.IdentifyCards(cards, ToDo, InProgress, Done);
            cardActions.BoardList(cards, ToDo, InProgress, Done);

            Actions actions = new Actions();
            UserInterface();
            string n = Console.ReadLine();
            int action = actions.PositiveCheck(n);


            //Expression (between)
            switch (action)
            {
                case 1:
                    cardActions.BoardList(cards, ToDo, InProgress, Done);
                    break;
                case 2:
                    cardActions.AddCard(cards, members);
                    break;
                case 3:
                    cardActions.Delete_card(cards);
                    break;
                case 4:
                    cardActions.Change_card(cards);
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
            Console.WriteLine("(1) List the board");
            Console.WriteLine("(2) Add cards to the board");
            Console.WriteLine("(3) Delete the card from the board");
            Console.WriteLine("(4) Change the cards");

        }

    }
}

