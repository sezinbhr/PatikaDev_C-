using System;

namespace Interfaces
{
    public class bmw_x5 : IAutomobile
    {
        public Brand CarBrand()
        {
            return Brand.BMW;

        }

        public Colors Stacolor()
        {
            return Colors.Gray;
        }

        public int WheelNumber()
        {
            return 4;
        }
    }
}