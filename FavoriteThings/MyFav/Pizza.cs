using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.MyFav
{
    class Pizza
    {
        public string Sauce { get; set; }
        public PizzaCrust Crust { get; set; }
        public void Eat(string typeOfFood)
        {
            Console.WriteLine($"Monique likes {typeOfFood} with {Sauce} and the crust should be {Crust}.");
        }
        public void Speciality(string typeOfMeat)
        {
            Console.Write($"Monique loves pizza with {typeOfMeat} and {Sauce} and {Crust}");
        }
    }
    enum PizzaCrust
    {
        Thin,
        HandTossed,
        Pan,
        Chicago

    }
}
