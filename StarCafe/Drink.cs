using System;
using System.Collections.Generic;
using System.Text;

namespace StarCafe
{   /// <summary>
/// Abstract class for any drinks in cafe.
/// </summary>
    public abstract class Drink
    {
        public string Description = "Unknown drink.";


        public abstract double GetPrice();

        public virtual string GetDescription()
        {
            return Description;
        }

    }
}
