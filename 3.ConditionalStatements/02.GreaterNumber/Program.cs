﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(firstNumber);
            }
        }
    }
}
