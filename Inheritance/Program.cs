using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedPlants seedPlant = new SeedPlants();
            seedPlant.Reproduce();


            Birds seagull = new Birds();
            seagull.Fly();

        }
    }
}
