using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingManiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyLeft = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int clothes = 0;
            int moneyForClothes = 0;

            while (text != "enough")
            {
                if (text == "enter")
                {

                    while (moneyLeft > 0 && text != "leave")
                    {
                        text = Console.ReadLine();
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

                    if (moneyLeft <= 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"For {clothes} clothes I spent {moneyForClothes} lv and have {money} lv left.");
        }
    }
}
