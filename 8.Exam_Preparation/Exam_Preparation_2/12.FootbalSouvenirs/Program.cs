using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FootbalSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int souvenirsBought = int.Parse(Console.ReadLine());
            double price = 0;

            if (team == "Argentina")
            {
                switch (souvenir)
                {
                    case "flags": price = 3.25; break;
                    case "caps": price = 7.20; break;
                    case "posters": price = 5.10; break;
                    case "stickers": price = 1.25; break;
                    default:
                        Console.WriteLine("Invalid stock!"); 
                        return;
                }
            }
            else if (team == "Brazil")
            {
                switch (souvenir)
                {
                    case "flags": price = 4.20; break;
                    case "caps": price = 8.50; break;
                    case "posters": price = 5.35; break;
                    case "stickers": price = 1.20; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else if (team == "Croatia")
            {
                switch (souvenir)
                {
                    case "flags": price = 2.75; break;
                    case "caps": price = 6.90; break;
                    case "posters": price = 4.95; break;
                    case "stickers": price = 1.10; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else if (team == "Denmark")
            {
                switch (souvenir)
                {
                    case "flags": price = 3.10; break;
                    case "caps": price = 6.50; break;
                    case "posters": price = 4.80; break;
                    case "stickers": price = 0.90; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            double totalPrice = souvenirsBought * price;
            Console.WriteLine($"Pepi bought {souvenirsBought} {souvenir} of {team} for {totalPrice:f2} lv.");
        }
    }
}
