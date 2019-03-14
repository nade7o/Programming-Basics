using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 5;
           
            decimal result = 1;
            
            for (int i = 0; i < m; i++)
            {
                result = result * n;
            }
            Console.WriteLine("{0} ^ {1} = {2}", n, m, result);
        }
    }
}
