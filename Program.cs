using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_Try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rental> rentals = new List<Rental>();
            //rentals.Add();
            Costumer costumer = new Costumer("Dmitry", rentals);
            rentals.Add(new Rental(new Movie("Friday 13th", 1), 10));
            rentals.Add(new Rental(new Movie("Meeting with parents", 2), 7));
            rentals.Add(new Rental(new Movie("Titanic", 3), 5));

            string filePath = "C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\VideoRental_Try\\Text.txt";
            using (StreamWriter streamWriter=new StreamWriter(filePath))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Клиент {costumer.Name} взял в аренду: ");
                foreach(var movieName in rentals)
                {
                    stringBuilder.AppendLine($"\t{movieName.Movie.Name} на {movieName.Days} за {movieName.Movie.Price}");
                }
                stringBuilder.AppendLine($"Общая сумма долга составляет: {costumer.CalculateCustomerDebt()}");
                streamWriter.WriteLine(stringBuilder.ToString());
            }
        }
    }
}
