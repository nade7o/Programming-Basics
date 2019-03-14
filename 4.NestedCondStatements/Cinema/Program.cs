using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double price = 1.00;

            if (projection == "Premiere")
            {
                price = 12.00;
            }
            else if (projection == "Normal")
            {
                price = 7.50;
            }
            else if (projection == "Discount")
            {
                price = 5.00;
            }
            Console.WriteLine("{0:f2}", column * row * price);
        }
    }
}
