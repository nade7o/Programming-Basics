using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ShoppingManiac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyLeft = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int clothes = 0;
            int moneyForClothes = 0;

            while (text != "enough" )
            {
                if (text == "enter")
                {
                    text = Console.ReadLine();
                    if (text == "leave")
                    {
                        text = Console.ReadLine();
                        break;
                    }
                    while (moneyLeft > 0 && text != "leave")
                    {
                       
                        if (text == "leave")
                        {
                            text = Console.ReadLine();
                            break;
                        }
                        int moneySpent = int.Parse(text);

                        if (moneySpent > moneyLeft)

                        {
                            Console.WriteLine("Not enough money.");
                            continue;
                        }
                        else
                        {

                            moneyLeft -= moneySpent;
                            moneyForClothes += moneySpent;
                            clothes++;
                        }
                    }
                    if (moneyLeft <= 0 )
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"For {clothes} clothes I spent {moneyForClothes} lv and have {moneyLeft} lv left.");
        }
    }
}
