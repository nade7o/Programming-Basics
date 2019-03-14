using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.UmiquePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1;  i++)
            {
                for (int k = 1; k <= num2 ; k++)
                {
                    for (int m = 1; m <= num3; m++)
                    {
                        if (i % 2 == 0 && m % 2 == 0)
                        {
                            if (k == 2 || k == 3 || k == 5 || k == 7)
                            {
                                Console.WriteLine($"{i} {k} {m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
