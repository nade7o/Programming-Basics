using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());


            double sum = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            double allToys = puzzles + dolls + bears + minions + trucks;

            if (allToys >= 50)
            {
                sum = (1 - 0.25) * sum;
            }
            sum = (1 - 0.10) * sum;

            if (sum >= tripPrice)
            {
                double moneyLeft = sum - tripPrice;
                Console.WriteLine("Yes! {0} lv left.", $"{moneyLeft:F2}");
            }
            else
            {
                double moneyNeeded = tripPrice - sum;
                Console.WriteLine("Not enough money! {0} lv needed.", $"{moneyNeeded:F2}");
            }

        }
    }
}
