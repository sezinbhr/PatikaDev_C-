using System;
using System.Collections.Generic;

namespace To_Do_App
{
    class CardActions
    {
        public void BoardList(List<Card> cards, List<Card> ToDo, List<Card> InProgress, List<Card> Done)
        {
            IdentifyCards(cards, ToDo, InProgress, Done);
            Console.WriteLine();

            Console.WriteLine("TO*DO Line");
            Console.WriteLine("************************");
            if (ToDo.Count == 0)
            {
                Console.WriteLine("The board list is empty!");
            }

            else
            {
                foreach (var b in ToDo)
                {
                    Console.WriteLine("Title      :{0}", b.title);
                    Console.WriteLine("Content    :{0}", b.content);
                    Console.WriteLine("Assigned to:{0}", b.member.Mem_name);
                    Console.WriteLine("Size       :{0}", b.size);
                    Console.WriteLine("-");

                }
            }
            Console.WriteLine();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (InProgress.Count == 0)
            {
                Console.WriteLine("The in progress list is empty!");
            }

            else
            {
                foreach (var i in InProgress)
                {
                    Console.WriteLine("Title      :{0}", i.title);
                    Console.WriteLine("Content    :{0}", i.content);
                    Console.WriteLine("Assigned to:{0}", i.member.Mem_name);
                    Console.WriteLine("Size       :{0}", i.size);
                    Console.WriteLine("-");

                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (Done.Count == 0)
            {
                Console.WriteLine("The done list is empty!");
            }

            else
            {
                foreach (var d in Done)
                {
                    Console.WriteLine("Title      :{0}", d.title);
                    Console.WriteLine("Content    :{0}", d.content);
                    Console.WriteLine("Assigned to:{0}", d.member.Mem_name);
                    Console.WriteLine("Size       :{0}", d.size);
                    Console.WriteLine("-");

                }
            }
        }

        public void AddCard(List<Card> cards, List<Member> member)
        {
            Card card = new Card();
            Console.WriteLine("Enter the title                              :");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the content                            :");
            string content = Console.ReadLine();
            Console.WriteLine("Choose the size -> XS(1),S(2),M(3),L(4),XL(5):");
            var size = (Size)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the member id                          :");
            int member_Id = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (var mem in member)
            {
                if (mem.Id == member_Id)
                {
                    cards.Add(new Card(title, content, size, mem, Type.ToDo));
                    Console.WriteLine("The card was added successfully");
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("You entered an incorrect value! There is no member found by given id");
            }

        }

        public void Delete_card(List<Card> cards)
        {
            Console.WriteLine("First you need to select the card you want to delete.");
            Console.WriteLine("Please write the card title");
            string title = Console.ReadLine();

            int count = 0;

            foreach (var c in cards)
            {
                if (c.title.ToLower() == title.ToLower())
                {
                    cards.Remove(c);
                    Console.WriteLine("The deletion was done");
                    count++;
                    break;
                }
            }

        }
        public void Change_card(List<Card> cards)
        {
            Console.WriteLine("First you need to select the card you want to change.");
            Console.WriteLine("Please write the card title");
            string title = Console.ReadLine();


            foreach (var b in cards)
            {
                if (b.title.ToLower() == title.ToLower())
                {
                    Console.WriteLine("Card Information:");
                    Console.WriteLine("**************************************");

                    Console.WriteLine("Title      :{0}", b.title);
                    Console.WriteLine("Content    :{0}", b.content);
                    Console.WriteLine("Assigned to:{0}", b.member.Mem_name);
                    Console.WriteLine("Size       :{0}", b.size);
                    Console.WriteLine("-");

                    Lineoption();
                    int chosen = int.Parse(Console.ReadLine());

                    if (chosen == 1)
                    {
                        b.type = Type.ToDo;
                    }

                    else if (chosen == 2)
                    {
                        b.type = Type.InProgress;
                    }

                    else if (chosen == 3)
                    {
                        b.type = Type.Done;

                    }
                    else
                    {
                        Console.WriteLine("You've chosen an incorrect value!");
                    }

                    Console.WriteLine("The card was changed successfully!");

                }

            }

        }
        public void Lineoption()
        {
            Console.WriteLine("Please select the line you want to change:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");

        }

        public void IdentifyCards(List<Card> cards, List<Card> ToDo, List<Card> InProgress, List<Card> Done)
        {
            ToDo.Clear();
            InProgress.Clear();
            Done.Clear();
            foreach (var t in cards)
            {
                if (t.type.Equals(Type.ToDo))
                {
                    ToDo.Add(t);
                }
                if (t.type.Equals(Type.InProgress))
                {
                    InProgress.Add(t);
                }
                if (t.type.Equals(Type.Done))
                {
                    Done.Add(t);
                }
            }
        }
    }
}
