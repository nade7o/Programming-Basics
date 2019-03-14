using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            int coins = 0;

            while (number > 0)
            {
                if (number >= 2)
                {
                    number -= 2;
                    coins++;
                }
                else if (number >= 1)
                {
                    number -= 1;
                    coins++;
                }
                else if (number >= 0.5m)
                {
                    number -= 0.5m;
                    coins++;
                }
                else if (number >= 0.2m)
                {
                    number -= 0.2m;
                    coins++;
                }
                else if (number >= 0.1m)
                {
                    number -= 0.1m;
                    coins++;
                }
                else if (number >= 0.05m)
                {
                    number -= 0.05m;
                    coins++;
                }
                else if (number >= 0.02m)
                {
                    number -= 0.02m;
                    coins++;
                }
                else if (number >= 0.01m)
                {
                    number -= 0.01m;
                    coins++;
                }

            }
            Console.WriteLine(coins);
        }
    }
}
