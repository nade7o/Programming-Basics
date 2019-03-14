using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfflowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 1.00;

            switch (flower)
            {
                case "Roses":
                    price = 5.00;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3.00;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }
            double finalPrice = numberOfflowers * price;
            double discount = 1.00;

            if (flower == "Roses" && numberOfflowers > 80)
            {
                discount = 0.10 * finalPrice;
                finalPrice = finalPrice - discount;
            }
            else if (flower == "Dahlias" && numberOfflowers > 90)
            {
                discount = 0.15 * finalPrice;
                finalPrice = finalPrice - discount;
            }
            else if (flower == "Tulips" && numberOfflowers > 80)
            {
                discount = 0.15 * finalPrice;
                finalPrice = finalPrice - discount;
            }
            else if (flower == "Narcissus" && numberOfflowers < 120)
            {
                discount = 0.15 * finalPrice;
                finalPrice = finalPrice + discount;
            }
            else if (flower == "Gladiolus" && numberOfflowers < 80)
            {
                discount = 0.20 * finalPrice;
                finalPrice = finalPrice + discount;
            }

            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numberOfflowers, flower, moneyLeft);
            }
            else
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
            }
        }
}
    }
