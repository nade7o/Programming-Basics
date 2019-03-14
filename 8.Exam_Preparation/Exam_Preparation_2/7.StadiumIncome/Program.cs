using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = capacity * ticketPrice;
            double sectorIncome = totalIncome / sectors;

            double moneyForCharity = (totalIncome - (sectorIncome * 0.75)) / 8;
            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
