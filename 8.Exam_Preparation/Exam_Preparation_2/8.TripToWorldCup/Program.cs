using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TripToWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketPriceGoing = double.Parse(Console.ReadLine());
            double ticketPriceComming = double.Parse(Console.ReadLine());
            double ticketPriceMatch = double.Parse(Console.ReadLine());
            int matches = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());

            double totalTicketsFlights = 6 * (ticketPriceGoing + ticketPriceComming);
            totalTicketsFlights = totalTicketsFlights - (totalTicketsFlights * (discount / 100));

            double totalMoneyForMatches = 6 * matches * ticketPriceMatch;
            double sumForAll = totalTicketsFlights + totalMoneyForMatches;
            double sumForOne = sumForAll / 6;

            Console.WriteLine($"Total sum: {sumForAll:F2} lv.");
            Console.WriteLine($"Each friend has to pay {sumForOne:F2} lv.");

        }
    }
}
