using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthEmptySpace = int.Parse(Console.ReadLine());
            int lenghtEmptySpace = int.Parse(Console.ReadLine());
            int heightEmptySpace = int.Parse(Console.ReadLine());
            int volumeRoom = widthEmptySpace * lenghtEmptySpace * heightEmptySpace;
            int sumCartoon = 0;

            while (volumeRoom > sumCartoon)
            {
                string enter = Console.ReadLine();
                if (enter == "Done")
                {
                    break;
                }
                int cartoon = int.Parse(enter);
                sumCartoon += cartoon;
            }
            int difference = volumeRoom - sumCartoon;

            if (difference >= 0)
            {
                Console.WriteLine($"{difference} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(difference)} Cubic meters more.");
            }
        }
    }
}
