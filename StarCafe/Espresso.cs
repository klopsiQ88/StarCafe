using System;
using System.Collections.Generic;
using System.Text;

namespace StarCafe
{
    public class Espresso : Drink
    {
        public Espresso()
        {
            Description = "Espresso cafe.";
        }

        public override double GetPrice()
        {
            return 1.99;
        }
    }
}
