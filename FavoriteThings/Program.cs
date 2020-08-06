using FavoriteThings.MyFav;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Designer Class properties
            var purse = new DesignerPurse(100, "Gucci");
            purse.Purchase("black", "clutch");

            // Pizza class properties
            var pizza = new Pizza();
            pizza.Sauce = "Marinara";
            pizza.Crust = PizzaCrust.Thin;
            pizza.Eat("pizza");

            //Jamaica class properties
            var jamaica = new Jamaica();
            jamaica.City = "Montego Bay";
            jamaica.Resort = "Sandals";
            jamaica.Travel("Jamaica");

            //Shoe class properties
            var shoes = new Shoes();
            shoes.Size = 8;
            shoes.Style = ShoeStyle.flats;
            shoes.Season("summer");
        }
    }
}
