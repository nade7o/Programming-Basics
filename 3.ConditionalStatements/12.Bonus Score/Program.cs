using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score > 100 && score < 1000)
            {
                bonus = 0.20 * score;
            }
            else
            {
                bonus = 0.10 * score;
            }

            if (score % 2 == 0)
            {
                bonus++;
            }
            else if (score % 10 == 5)
            {
                bonus += 2;
            }
            double total = score + bonus;
            Console.WriteLine(bonus);
            Console.WriteLine(total);
        }
    }
}
