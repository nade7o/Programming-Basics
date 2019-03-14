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
            double count4 = 0;
            double count5 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (1 <= num && num < 200)
                {
                    count1++;
                    p1 = count1 / (n * 100);
                }
                else if (200 <= num && num < 400)
                {
                    count2++;
                    p2 = count2 / (n * 100);
                }
                else if (400 <= num && num < 600)
                {
                    count3++;
                    p3 = count3 / (n * 100);
                }
                else if (600 <= num && num < 800)
                {
                    count4++;
                    p4 = count4 / (n * 100);
                }
                else if (num >= 800)
                {
                    count5++;
                    p5 = count5 / (n * 100);
                }
            }
                Console.WriteLine("{0:P}", p1 * 100);
                Console.WriteLine("{0:P}", p2 * 100);
                Console.WriteLine("{0:P}", p3 * 100);
                Console.WriteLine("{0:P}", p4 * 100);
                Console.WriteLine("{0:P}", p5 * 100);

        }
    }
}
