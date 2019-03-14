using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstNum = num % 10;
            num = num / 10;
            int secondNum = num % 10;
            num = num / 10;
            int thirdNum = num % 10;
            num = num / 10;

            for (int i = 1; i <=  firstNum; i++)
            {
                for (int k = 1; k <= secondNum; k++)
                {
                    for (int m = 1; m <= thirdNum; m++)
                    {
                        int result = i * k * m;
                        Console.WriteLine($"{i} * {k} * {m} = {result};");
                    }
                }
            }
        }
    }
}
