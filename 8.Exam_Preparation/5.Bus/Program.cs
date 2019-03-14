using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= stops; i++)
            {
                int passengersGoingDown = int.Parse(Console.ReadLine());
                int passengersGoingUP = int.Parse(Console.ReadLine());
                passengers = passengers - passengersGoingDown + passengersGoingUP;

                if (i % 2 == 0)
                {
                    passengers -= 2;
                }
                else
                {
                    passengers += 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
