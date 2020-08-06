using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.MyFav
{
    class Jamaica
    {
        //write method
        public void Travel(string cityToTravel)
        {
            Console.WriteLine($"My favorite place to travel is {cityToTravel}, and I stay in {City} at an all inclusive resort {Resort}.");
        }
        // properties with getter and setter
        public string City { get; set; }
        public string Resort { get; set; }
    }
}
