using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= maxNum)
                {
                    maxNum = num;
                }
                sum += num;
            }
            sum -= maxNum;
                if (sum == maxNum)
                {
                    Console.WriteLine("Yes Sum = " + maxNum);                
                }
                else
                {              
                Console.WriteLine("No Diff = " + Math.Abs(sum - maxNum));           
                }
            
        }
    }
}
