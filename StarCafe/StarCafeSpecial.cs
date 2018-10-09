using System;
using System.Collections.Generic;
using System.Text;

namespace StarCafe
{
    public class StarCafeSpecial : Drink
    {
        public StarCafeSpecial()
        {
            Description = "StarCafeSpecial.";
        }

        public override double GetPrice()
        {
            return 0.99;
        }
    }
}
