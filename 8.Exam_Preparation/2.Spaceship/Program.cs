using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double peopleHeight = double.Parse(Console.ReadLine());

            double shipVolume = shipWidth * shipLength * shipHeight;
            double roomVolume = 2 * 2 * (peopleHeight + 0.40);

            double peopleCount =Math.Floor(shipVolume / roomVolume);

            if (3 < peopleCount &&  peopleCount < 10)
            {
                Console.WriteLine($"The spacecraft holds {peopleCount} astronauts.");
            }
            else if (peopleCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (peopleCount > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
