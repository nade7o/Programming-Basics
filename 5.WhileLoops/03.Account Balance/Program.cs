using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeposit = int.Parse(Console.ReadLine());
            int currentNumberOfDeposit = 0;
            double sum = 0;

            while (currentNumberOfDeposit < numberOfDeposit)
            {
                double currentSum = double.Parse(Console.ReadLine());

                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {currentSum:f2} ");
                sum += currentSum;
                currentNumberOfDeposit++;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
