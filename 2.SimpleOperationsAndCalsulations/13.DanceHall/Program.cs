using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double stranaA = double.Parse(Console.ReadLine());

            double hallSize = (lenght * 100) * (width * 100);
            double wardrobe = (stranaA * 100) * (stranaA * 100);
            double bench = hallSize / 10.00;
            double personSpare = 40.00 + 7000.00;
            double spareSpace = hallSize - wardrobe - bench;

            double peopleInHall = spareSpace / personSpare;

            Console.WriteLine(Math.Floor(peopleInHall));
        }
    }
}