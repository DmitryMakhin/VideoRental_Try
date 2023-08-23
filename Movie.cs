using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_Try
{
    public class Movie
    {
        int price;
        string name;
        //MovieType type;
        public int Price { get { return price; } }
        public string Name { get { return name; } }
        //public MovieType Type { get { return type; } }
        public Movie(string name, int price)
        {
            this.name = name;
            this.price = price;
            //this.type = type;
        }
    }
}
