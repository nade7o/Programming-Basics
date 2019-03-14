using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int fuelConsumption = int.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            int moneyEarned = int.Parse(Console.ReadLine());

            double carCost = (distance / 100.0) * fuelConsumption;
            carCost = carCost * fuelPrice;


            if (moneyEarned >= carCost)
            {
                double money = moneyEarned - carCost;
                Console.WriteLine("You can go home. {0:f2} money left.", money);
            }
            else if (moneyEarned < carCost)
            {
                double moneyForEach = moneyEarned / 5.0;
                Console.WriteLine("Sorry, you cannot go home. Each will receive {0:f2} money.", moneyForEach);
            }
        }
    }
}
