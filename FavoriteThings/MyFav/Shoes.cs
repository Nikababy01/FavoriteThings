using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.MyFav
{
    class Shoes
    {
        //write method
        public void Season(string typeOfShoe)
        {
            Console.WriteLine($"My favorite {typeOfShoe} shoe are {Style} and a size {Size}.");
        }
        public int Size { get; set; }
        public ShoeStyle Style { get; set; }
    }
        enum ShoeStyle
        {
            boots,
            loafers,
            crocs,
            tennis,
            flats,
            wedges,
            stilettos
        }
   
}
