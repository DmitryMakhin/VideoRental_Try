using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_Try
{
    public class Rental
    {
        Movie movie;
        int days;
        public Movie Movie{ get { return movie; } }
        public int Days { get { return days; } }
        public Rental(Movie movie,int days)
        {
            this.movie = movie;
            this.days = days;
        }

        public int CalculateDebt()
        {
            return Movie.Price * Days;
        }
    }
}
