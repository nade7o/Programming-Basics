using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    counter++;
                    Console.Write(counter + " ");
                    if (counter == n)
                    {
                        return;
                     }

                }
                Console.WriteLine();
            }
        }
    }
}
