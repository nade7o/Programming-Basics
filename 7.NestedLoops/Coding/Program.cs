using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberString = number.ToString();
            int rows = numberString.Length;
            while(rows > 0)
            {
                int ones = number % 10;
                int asciNum = ones + 33;
                if (ones == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    for (int i = 1; i <= ones; i++)
                    {
                        Console.Write((char)asciNum);
                    }
                    Console.WriteLine();
                }
                
               
                number = number - ones;
                number = number / 10;
                rows--;
            }

        }
    }
}
