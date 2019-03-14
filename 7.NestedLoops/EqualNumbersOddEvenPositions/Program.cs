using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbersOddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int currentNum = 0;

            for (int i = number1; i <= number2; i++)
            {
                currentNum = i;
                for (int j = 1; j <= 6 ; j++)
                {
                    int lastNum = currentNum % 10;
                    currentNum = (currentNum - lastNum) / 10;
                }
            }
        }
    }
}
