using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.MyFav
{
    class Pizza
    {
        public void Eat(string typeOfFood)
    {
        Console.WriteLine($"Monique likes {typeOfFood} with {Sauce} and the crust should be {Crust}.");
    }
        public string Sauce { get; set; }
        public PizzaCrust Crust { get; set; }
    }
    enum PizzaCrust
    {
        Thin,
        HandTossed,
        Pan,
        Chicago

    }
      
}
