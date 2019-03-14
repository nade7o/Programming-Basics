using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyCash = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpent = 0;
            double money = 0;
            string activity = string.Empty;

            while (true)
            {
                activity = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                days++;

                if (activity == "spend")
                {
                    moneyCash -= money;

                    if (money > moneyCash)
                    {
                        moneyCash = 0;
                    }

                    daysSpent++;
                }
                else if (activity == "save")
                {
                    daysSpent = 0;
                    moneyCash += money;
                    if (moneyCash >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }

                if (daysSpent == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }

            }
        }
    }
}
