using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyQuota = int.Parse(Console.ReadLine());
            string fishName = "";
            double fishPrice = 0;
            double sum = 0;
            double fishCost = 0;
            double fishProfit = 0;

            for (int i = 1; i <= dailyQuota; i++)
            {
                fishPrice = 0;
                sum = 0;
                fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    if (fishProfit >= fishCost)
                    {
                        double moneyEarned = (fishProfit - fishCost);
                        Console.WriteLine($"Lyubo's profit from {i-1} fishes is {moneyEarned:f2} leva.");
                    }
                    else
                    {
                        double losts = (fishCost - fishProfit);
                        Console.WriteLine($"Lyubo lost {losts:f2} leva today.");
                    }
                    return;
                }

                double kg = double.Parse(Console.ReadLine());
                for (int letter = 0; letter < fishName.Length; letter++)
                {
                    sum += fishName[letter];
                }
                fishPrice = sum / kg;
                if (i % 3 == 0)
                {
                    fishProfit += fishPrice;
                }
                else
                {
                    fishCost += fishPrice;
                }
                
            }
            Console.WriteLine("Lyubo fulfilled the quota!");
            if (fishProfit >= fishCost)
            {
                double moneyEarned = (fishProfit - fishCost);
                Console.WriteLine($"Lyubo's profit from {dailyQuota} fishes is {moneyEarned:f2} leva.");
            }
            else
            {
                double losts = (fishCost - fishProfit);
                Console.WriteLine($"Lyubo lost {losts:f2} leva today.");
            }
        }
    } 
 }
    

