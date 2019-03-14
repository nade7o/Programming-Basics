using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double reachedSum = double.Parse(Console.ReadLine());

            double shortPrice = 0.75 * tshirtPrice;
            double socksPrice = 0.20 * shortPrice;
            double buttonsPrice = 2 * (tshirtPrice + shortPrice);

            double total = tshirtPrice + shortPrice + socksPrice + buttonsPrice;
            total = total - (total * 0.15);

            if (total >= reachedSum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else
            {
                double moneyNeeded = reachedSum - total;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }
        }
    }
}
