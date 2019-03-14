using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling((steps * 1.0 / days) / steps * 100);
            double stepsForEveryDancer = stepsPerDay / dancers;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsForEveryDancer:F2}%.");
            }
            else if (stepsPerDay > 13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsForEveryDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
