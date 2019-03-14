using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double ivanchoTime = double.Parse(Console.ReadLine());

            double timeSpent = distance * ivanchoTime;
            double timesSlow = Math.Floor(distance / 15);
            double aditionalTime = timesSlow * 12.5;
            timeSpent = timeSpent + aditionalTime;

            if (timeSpent < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeSpent:F2} seconds.");
            }
            else if (timeSpent >= record)
            {
                double difference = timeSpent - record;
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
        }
    }
}
