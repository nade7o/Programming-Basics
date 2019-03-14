using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ComputerFilm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rating = 0;
            int sales = 0;
            double percent = 0;
            double ratingCount = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                 rating = number % 10;
                 sales = number / 10;
                 percent = 0;


                if (rating == 2)
                {
                    percent = 1.0;
                    ratingCount += rating;
                }
                else if (rating == 3)
                {
                    percent = 0.5 ;
                    ratingCount += rating;
                }
                else if (rating == 4)
                {
                    percent = 0.7;
                    ratingCount += rating;
                }
                else if (rating == 5)
                {
                    percent = 0.85;
                    ratingCount += rating;
                }
                else if (rating == 6)
                {
                    percent = 0.1;
                    ratingCount += rating;
                }
            }
            double sale = rating * (sales * percent);
            sale += sale;
            
            double averageRating = ratingCount / n;
            Console.WriteLine("{0:f2}", sale);
            Console.WriteLine("{0:f2}", averageRating);
        }
    }
}
