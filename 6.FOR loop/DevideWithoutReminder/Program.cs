using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;           

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    count1++;
                    p1 = count1 / n;
                }
                if (num % 3 == 0)
                {
                    count2++;
                    p2 = count2 / n;
                }
                if (num % 4 == 0)
                {
                    count3++;
                    p3 = count3 / n ;
                }
                
            }
            Console.WriteLine("{0:F2}%", p1 * 100 );
            Console.WriteLine("{0:F2}%", p2 * 100 );
            Console.WriteLine("{0:F2}%", p3 * 100 );
        }
    }
}
