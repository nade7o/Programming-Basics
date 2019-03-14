using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EqualSumOddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for(int i = num1; i <=num2; i++)
            {
                int tempNum = i;    
                int odds = 0;
                int evens = 0;
                while(tempNum > 0)
                {
                    odds += tempNum % 10;
                    tempNum = tempNum / 10;

                    evens += tempNum % 10;
                    tempNum = tempNum / 10;
                }                
                
                if(odds == evens)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
