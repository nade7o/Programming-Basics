using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floorCurrent = floors; floorCurrent >= 1; floorCurrent--)
            {
                for (int roomCurrent = 0; roomCurrent < rooms; roomCurrent++)
                {
                    if (floorCurrent == floors)
                    {
                        Console.Write($"L{floorCurrent}{roomCurrent} ");
                    }
                    else if (floorCurrent % 2 == 0)
                    {
                        Console.Write($"O{floorCurrent}{roomCurrent} ");
                    }
                    else
                    {
                        Console.Write($"A{floorCurrent}{roomCurrent} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
