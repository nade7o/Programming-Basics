using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0.0;

            if (operation == '+')
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
            }
            else if (operation == '-')
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }

            else if (operation == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }

            }
            else if (operation == '/')
            {

                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero ");
                }

            }
            else if (operation == '%')
            {
                if (n2 != 0)
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero ");
                }

            }
        }
    }
}
