

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beerCost = 1.20 * beers;
            double chipsPrice = 0.45 * beerCost;
            double chipsCost = Math.Ceiling(chipsPrice * chips);
            double costs = beerCost + chipsCost;
            double diff = Math.Abs(budget - costs);
            if (budget >= costs)
            {
                Console.WriteLine($"{name} bought a snack and has {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {diff:f2} more leva!");
            }
        }
    }
}
