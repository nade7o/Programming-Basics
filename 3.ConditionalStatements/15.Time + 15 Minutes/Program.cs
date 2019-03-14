using System;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins = mins + 15;

            if (mins > 59)
            {
                hours++;
                mins = mins - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (mins < 10)
            {
                Console.WriteLine(hours + ":0" + mins);
            }
            else
            {
                Console.WriteLine(hours + ":" + mins);
            }
        }
    }
}
