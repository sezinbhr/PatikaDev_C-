using System;
namespace Inheritance
{
    public class Plants : Creatures
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants do the photosynthesis");
        }

    }

    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Food();
            base.Excretory();
            base.Breathe();

        }
        public void Reproduce()
        {
            Console.WriteLine("They reproduce with seeds and pollen.");
        }
    }
    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
            base.Food();
            base.Excretory();
            base.Breathe();
        }
        public void Reproduce()
        {
            Console.WriteLine("They reproduce with spores.");
        }

    }
}