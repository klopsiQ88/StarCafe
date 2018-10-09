using System;
using System.Collections.Generic;
using System.Text;

namespace StarCafe
{
    public class Chocolate : AdditionalComponents
    {
        Drink baseDrink;

        public Chocolate(Drink baseDrink)
        {
            this.baseDrink = baseDrink;
        }

        public override string GetDescription()
        {
            return baseDrink.GetDescription() + " and add of chocolate";
        }



        public override double GetPrice()
        {
            return baseDrink.GetPrice() + 0.20;
        }
    }
}
