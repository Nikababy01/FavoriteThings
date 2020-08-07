using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.MyFav
{
    class DesignerPurse
    {
        public int Price { get; set; }
        public string Designer { get; set; }
        public DesignerPurse(int price, string designer)
        {

            Price = price;
            Designer = designer;
        }
        public void Purchase(string color, string style)
        {
            Console.WriteLine($"Monique purchased a {color} {style} purse for {Price} dollars from {Designer}.");

        }
        public void Sell()
        {
            if (Price >= 100)
            {
                Console.WriteLine($"Monique will keep all {Designer} that cost more than {Price}.");
            }
            else
            {
                Console.WriteLine($"Monique can sell {Designer} since it is cheap!");
            }
        }
    }
}
