using System;
namespace Inheritance
{
    public class Animals : Creatures
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals have a talent for the adaptation");
        }

    }

    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Food();
            base.Excretory();
            base.Breathe();

        }
        public void Crawl()
        {
            Console.WriteLine("The reptiles can crawl");
        }
    }

    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Food();
            base.Excretory();
            base.Breathe();

        }
        public void Fly()
        {
            Console.WriteLine("Birds can fly!");
        }
    }
}