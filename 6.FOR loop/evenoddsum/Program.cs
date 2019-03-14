using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum = oddSum + int.Parse(Console.ReadLine());
                }
            }
            int diference = Math.Abs(evenSum - oddSum);
            if (diference == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diference);
            }
        }
    }
}
