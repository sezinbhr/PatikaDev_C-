using System;

namespace Interfaces
{
    public class carrera : IAutomobile
    {
        public Brand CarBrand()
        {
            return Brand.Porsche;
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
