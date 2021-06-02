using System;

namespace Interfaces
{
    public class audi_a5 : IAutomobile
    {
        public Brand CarBrand()
        {
            return Brand.Audi;
        }

        public Colors Stacolor()
        {
            return Colors.White;
        }

        public int WheelNumber()
        {
            return 4;
        }
    }
}