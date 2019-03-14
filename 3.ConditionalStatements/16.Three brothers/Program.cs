using System;

namespace threeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());


            double timeWithRest = 1 / ((1 / A) + (1 / B) + (1 / C)) * 1.15;

            if (D > timeWithRest)
            {
                double timeLeft = D - timeWithRest;
                Console.WriteLine($"Cleaning time: {timeWithRest:f2}");
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeLeft));
            }

            else
            {
                double timeLeft = timeWithRest - D;
                Console.WriteLine($"Cleaning time: {timeWithRest:f2}");
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(timeLeft));
            }

        }
    }
}
