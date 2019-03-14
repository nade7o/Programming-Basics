using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n ; i++)
            {
                for (int k = 1; k < n; k++)
                {
                    for (char m = 'a'; m < 'a' + l; m++)
                    {
                        for (char r = 'a'; r < 'a' + l; r++)
                        {
                            for (int b = 1; b <= n ; b++)
                            {
                                if (b > i && b > k)
                                {
                                    Console.Write($"{i}{k}{m}{r}{b} ");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
