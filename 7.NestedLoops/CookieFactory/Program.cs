using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch = int.Parse(Console.ReadLine());

            for (int i = 1; i <= batch; i++)
            {
                bool isEggs = false;
                bool isFlour = false;
                bool isSugar = false;
                bool readyToBake = false;

                while (!readyToBake)
                {
                    string ingredient = Console.ReadLine();

                    if (ingredient == "eggs")
                    {
                        isEggs = true;
                    }
                    else if (ingredient == "flour")
                    {
                        isFlour = true;
                    }
                    else if (ingredient == "sugar")
                    {
                        isSugar = true;
                    }
                    else if (ingredient == "Bake!")
                    {
                        if (isEggs && isFlour && isSugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            readyToBake = true;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }
        }
    }
}