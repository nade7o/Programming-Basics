using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine().ToLower();

            if (dayTime == "morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
            }
            else if (dayTime == "afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot.", degrees);
                }
            }
            else if (dayTime == "evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees >= 25)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
            }
        }
    }
}
