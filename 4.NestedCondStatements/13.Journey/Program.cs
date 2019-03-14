using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string rest = "";
            var amountSpent = 1.0;

            if (budget <= 100 && season == "summer")
            {
                destination = "Somewhere in Bulgaria";
                rest = "Camp";
                amountSpent = budget * 0.3;
            }

            else if (budget <= 100 && season == "winter")
            {
                destination = "Somewhere in Bulgaria";
                rest = "Hotel";
                amountSpent = budget * 0.7;
            }


            else if (budget <= 1000 && season == "summer")
            {
                destination = "Somewhere in Balkans";
                rest = "Camp";
                amountSpent = budget * 0.4;
            }
            else if (budget <= 1000 && season == "winter")
            {
                destination = "Somewhere in Balkans";
                rest = "Hotel";
                amountSpent = budget * 0.8;
            }

            else
            {
                destination = "Somewhere in Europe";
                rest = "Hotel";
                amountSpent = budget * 0.9;
            }
            Console.WriteLine(destination);
            Console.WriteLine("{0}" + " - " + "{1:f2}", rest, amountSpent);

        }
    }
}

