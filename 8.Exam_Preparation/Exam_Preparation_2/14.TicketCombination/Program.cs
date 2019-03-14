using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

           for (char i = 'B'; i <= 'L'; i++)
           {
                for (char k = 'f'; k >= 'a'; k--)
                {
                    for (char m = 'A'; m <= 'C'; m++)
                    {
                        for (int l = 1; l <= 10 ; l++)
                        {
                            for (int g = 10; g >= 1; g--)
                            {
                                if (i % 2 == 0)
                                {
                                    counter++;
                                }
                                if (counter == number)
                                {
                                    Console.WriteLine($"Ticket combination: {i}{k}{m}{l}{g}");
                                    int prize = i + k + m + l + g;
                                    Console.WriteLine($"Prize: {prize} lv.");
                                }
                            }
                        }
                    }
                }
           }
        }
    }
}
