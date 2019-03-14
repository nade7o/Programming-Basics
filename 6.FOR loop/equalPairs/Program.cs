using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previuosSum = 0;
            int diff = 0;
            int biggestDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    previuosSum = firstNum + secondNum;
                }
                else
                {
                    int currentSum = firstNum + secondNum;
                    diff = Math.Abs(currentSum - previuosSum);

                    if (diff > biggestDiff)
                    {
                        biggestDiff = diff;
                    }
                    previuosSum = currentSum;
                }
            }
                if (biggestDiff == 0)
                {
                    Console.WriteLine($"Yes, value = {previuosSum}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={biggestDiff}");
                }
            
        }
    }
}
