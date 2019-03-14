using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaignDays = int.Parse(Console.ReadLine());
            int sweeties = int.Parse(Console.ReadLine());

            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45.00;
            double waferPrice = 5.80;
            double pancakePrice = 3.20;

            double cakeSum = cakes * cakePrice;
            double waferSum = wafers * waferPrice;
            double pancakeSum = pancakes * pancakePrice;

            double sumPerDay = (cakeSum + waferSum + pancakeSum) * sweeties;
            double campaignSum = sumPerDay * campaignDays;
            double costs = campaignSum * (1.00 / 8.00);
            double sumAfterCost = campaignSum - costs;

            Console.WriteLine($"{sumAfterCost:F2}");
        }
    }
}
