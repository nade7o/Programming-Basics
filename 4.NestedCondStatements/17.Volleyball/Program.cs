using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsAbroad = int.Parse(Console.ReadLine());

            double weekendsInSoia = 48 - weekendsAbroad;
            double playsinSofia = weekendsInSoia * (3.0 / 4);

            double playsAboad = weekendsAbroad;

            double playsInHolidays = holidays * (2.0 / 3);

            double sumPlays = playsinSofia + playsAboad + playsInHolidays;

            if (yearType == "leap")
            {
                sumPlays += (0.15 * sumPlays);
            }
            Console.WriteLine(Math.Truncate(sumPlays));
        }
    }
}
