﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           double num = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (n == 1)
            {
                num = double.Parse(Console.ReadLine());
                Console.WriteLine($"OddSum={num},");
                Console.WriteLine($"OddMin={num},");
                Console.WriteLine($"OddMax={num},");
                Console.WriteLine($"EvenSum=0,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    num = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum += num;
                        if (num > evenMax)
                        {
                            evenMax = num;
                        }
                        if (num < evenMin)
                        {
                            evenMin = num;
                        }
                    }
                    else
                    {
                        oddSum += num;
                        if (num > oddMax)
                        {
                            oddMax = num;
                        }
                        if (num < oddMin)
                        {
                            oddMin = num;
                        }
                    }
                }
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");
            }
           

        }
    }
}
