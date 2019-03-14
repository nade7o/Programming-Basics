using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int hoursSpent = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double pricePerHour = 0.0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (dayOrNight == "day")
                {
                    pricePerHour = 10.50;
                }
                else if (dayOrNight == "night")
                {
                    pricePerHour = 8.40;
                }

            }

            else if (month == "june" || month == "july" || month == "august")
            {
                if (dayOrNight == "day")
                {
                    pricePerHour = 12.60;
                }
                else if (dayOrNight == "night")
                {
                    pricePerHour = 10.20;
                }
            }
            if (people >= 4)
            {
                pricePerHour = pricePerHour - (0.10 * pricePerHour);
            }

            if (hoursSpent >= 5)
            {

                pricePerHour = pricePerHour - (0.50 * pricePerHour);
            }
            double priceForAll = (people * hoursSpent) * pricePerHour;

            Console.WriteLine($"Price per person for one hour: {pricePerHour:f2}");
            Console.WriteLine($"Total cost of the visit: {priceForAll:f2}");
        }
    }
}