using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_Try
{
    public class Costumer
    {
        string name;
        List<Rental> rentals = new List<Rental>();
        public string Name { get { return name; } }
        public List<Rental> Rentals { get { return rentals; } }
        public Costumer(string name, List<Rental> rentals)
        {
            this.name = name;
            this.rentals = rentals;
        }
        public int CalculateCustomerDebt()
        {
            int finalSum = 0;
            foreach (var debt in rentals)
            {
                finalSum += debt.CalculateDebt();
            }
            return finalSum;
        }
    }
}
