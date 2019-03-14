using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int totalSec = sec1 + sec2 + sec3;
            int min = totalSec / 60;
            int sec = totalSec % 60;

            if (sec < 10)
            {
                Console.WriteLine(min + ":0" + sec);
            }
            else
            {

                Console.WriteLine(min + ":" + sec);
            }

        }
    }
}
