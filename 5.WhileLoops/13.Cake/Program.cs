using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int piecesAll = width * lenght;
            int piecesEntered = 0;
            string enter = String.Empty;

            while (true)
            {
                enter = Console.ReadLine();
                if (enter == "STOP" && piecesEntered <= piecesAll)
                {
                    int piecesLeft = piecesAll - piecesEntered;
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    break;
                }

                int piece = int.Parse(enter);
                piecesEntered += piece;


                if (piecesEntered > piecesAll)
                {
                    int piecesNeeded = piecesEntered - piecesAll;
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    break;
                }
            }
        }
    }
}
