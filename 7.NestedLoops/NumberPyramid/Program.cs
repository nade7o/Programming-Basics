using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.WriteLine(sum+ " ");
                    sum++;
                    if (sum > n)
                    {
                        break;
                    }
                }
            }
        }
    }
}
