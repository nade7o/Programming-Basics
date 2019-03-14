using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.EqualSumLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i ++)
            {
                int tempNum = i;
                int rightSum = 0;
                int leftSum = 0;

                rightSum += tempNum % 10;
                tempNum = tempNum / 10;
                rightSum += tempNum % 10;
                tempNum = tempNum / 10;

                int midSymbol = tempNum % 10;

                tempNum = tempNum / 10;
                leftSum += tempNum % 10;
                tempNum = tempNum / 10;
                leftSum += tempNum % 10;

                if (rightSum < leftSum)
                {
                    rightSum += midSymbol;
                    if(rightSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                else if (rightSum > leftSum)
                {
                    leftSum += midSymbol;
                    if (rightSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
