using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sushi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restourantName = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());
            double sushiPrice = 0;

            if (restourantName == "Sushi Zone")
            {
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 4.99; break;
                    case "maki": sushiPrice = 5.29; break;
                    case "uramaki": sushiPrice = 5.99; break;
                    case "temaki": sushiPrice = 4.29; break;
                }
            }
            else if (restourantName == "Sushi Time")
            {
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 5.49; break;
                    case "maki": sushiPrice = 4.69; break;
                    case "uramaki": sushiPrice = 4.49; break;
                    case "temaki": sushiPrice = 5.19; break;
                }
            }
            else if (restourantName == "Sushi Bar")
            {
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 5.25; break;
                    case "maki": sushiPrice = 5.55; break;
                    case "uramaki": sushiPrice = 6.25; break;
                    case "temaki": sushiPrice = 4.75; break;
                }
            }
            else if (restourantName == "Asian Pub")
            {
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 4.50; break;
                    case "maki": sushiPrice = 4.80; break;
                    case "uramaki": sushiPrice = 5.50; break;
                    case "temaki": sushiPrice = 5.50; break;
                }
            }
            else
            {
                Console.WriteLine($"{restourantName} is invalid restaurant!");
                return;
                
            }
            double orderPrice = sushiPrice * portions;
            double deliveryPrice = 0;
            double totalCost = 0;

            if (order == 'Y')
            {
                deliveryPrice = orderPrice * 0.20 ;
                totalCost = orderPrice + deliveryPrice;
            }
            else
            {
                totalCost = orderPrice;
            }
            Console.WriteLine($"Total price: {Math.Ceiling(totalCost)} lv.");
        }
    }
}
