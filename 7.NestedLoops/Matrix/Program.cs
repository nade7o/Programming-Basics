using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int first = a; first <= b; first++)
            {
                for (int second = a; second <= b; second++)
                {
                    for (int third = c; third <= d; third++)
                    {
                        for (int forth = c; forth <= d; forth++)
                        {
                            if (first != second && third != forth)
                            {
                                if (first + forth == third + second)
                                {
                                    Console.WriteLine($"{first}{second}");
                                    Console.WriteLine($"{third}{forth}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
