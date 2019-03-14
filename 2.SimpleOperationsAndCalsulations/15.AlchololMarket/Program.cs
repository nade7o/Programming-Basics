using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AlchololMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2.00;
            double winePrice = rakiaPrice - (0.40 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.80 * rakiaPrice);

            double sum = (whiskey * whiskeyPrice) + (beer * beerPrice) + (wine * winePrice) + (rakia * rakiaPrice);
            Console.WriteLine($"{sum:F2}");
        }
    }
}
