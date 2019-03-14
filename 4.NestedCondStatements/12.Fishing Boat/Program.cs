using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            int rentBoat = 0;
            double discount = 0.0;
            double bonusDiscount = 0.0;

            if (season == "Spring")
            {
                rentBoat = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rentBoat = 4200;
            }
            else if (season == "Winter")
            {
                rentBoat = 2600;
            }

            if (fishermen <= 6)
            {
                discount = 0.10 * rentBoat;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = 0.15 * rentBoat;
            }
            else
            {
                discount = 0.25 * rentBoat;
            }

            double sumAfterDiscount = rentBoat - discount;

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                bonusDiscount = 0.05 * sumAfterDiscount;
            }
            sumAfterDiscount = sumAfterDiscount - bonusDiscount;

            if (budget >= sumAfterDiscount)
            {
                double moneyLeft = budget - sumAfterDiscount;
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
            }
            else
            {
                double moneyNeeded = sumAfterDiscount - budget;
                Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
            }

        }
    }
}
