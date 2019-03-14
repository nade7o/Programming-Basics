using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumPrimeNotPrime
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            bool isPrime = true;
            int sumPrime = 0;
            int sumNonPrime = 0;

            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "stop")
            {
                number = int.Parse(command);
                isPrime = true;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (number == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = number; i >= 2; i--)
                    {
                        if (number % i == 0 && i != number)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
