using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double fool = ((210 * 2) / 100.0) * 7.0;
            double foolCost = fool * 1.85;

            double foodAndSouvenrCost = (3 * moneyForFood) + (3 * moneyForSouvenirs);

            double firstDayCost = moneyForHotel - (moneyForHotel * 0.10);
            double secondDayCost = moneyForHotel - (moneyForHotel * 0.15);
            double thirdDayCost = moneyForHotel - (moneyForHotel * 0.20);

            double moneyNeeded = foolCost + foodAndSouvenrCost + firstDayCost + secondDayCost + thirdDayCost;

            Console.WriteLine($"Money needed: {moneyNeeded:f2}");
        }
    }
}
