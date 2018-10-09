using System;
using System.Collections.Generic;

namespace StarCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Espresso();
            Console.WriteLine(drink.GetDescription()+ drink.GetPrice().ToString());

            Drink secondDrink = new StarCafeSpecial();
            secondDrink = new Chocolate(secondDrink);

            Console.WriteLine(secondDrink.GetDescription() + secondDrink.GetPrice().ToString());
            Console.ReadLine();
        }
    }
}
