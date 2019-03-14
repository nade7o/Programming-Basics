using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApart = 0.0;
            double obshtoApart = 0.0;
            double obshtoStudio = 0.0;


            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApart = 65;

                if (overnight > 7 && overnight <= 14)
                {
                    priceStudio = 50 - (0.05 * 50);

                }
                else if (overnight > 14)

                {
                    priceStudio = 50 - (0.3 * 50);
                    priceApart = 65 - (0.1 * 65);

                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApart = 68.70;

                if (overnight > 14)
                {
                    priceStudio = 75.20 - (0.2 * 75.20);
                    priceApart = 68.70 - (0.1 * 68.70);
                }

            }

            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApart = 77;

                if (overnight > 14)
                {
                    priceApart = 77 - (0.1 * 77);
                }

            }
            obshtoApart = priceApart * overnight;
            obshtoStudio = priceStudio * overnight;
            Console.WriteLine("Apartment: {0:f2} lv.", obshtoApart);
            Console.WriteLine("Studio: {0:f2} lv.", obshtoStudio);
        }
    }
}
