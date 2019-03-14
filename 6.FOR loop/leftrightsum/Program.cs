using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftrightsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }
                int difference = Math.Abs(leftSum - rightSum);
                if (difference == 0)
                {
                    Console.WriteLine("Yes, sum = " + leftSum);
                }
                else
                {
                    Console.WriteLine("No, diff = " + difference);
                }
            
        }
    }
}
