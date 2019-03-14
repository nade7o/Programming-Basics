using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMinute;
            int arrivalTime = (arrivalHour * 60) + arrivalMinute;
            int minutesDiference = examTime - arrivalTime;

            if (minutesDiference >= 0 && minutesDiference <= 30)
            {
                Console.WriteLine("On time");
            }

            else if (minutesDiference < 0)
            {
                Console.WriteLine("Late");
            }
            else if (minutesDiference > 30)
            {
                Console.WriteLine("Early");
            }

            if (minutesDiference < 60 && minutesDiference > 0)
            {
                Console.WriteLine($"{minutesDiference} minutes before the start");
            }
            else if (minutesDiference >= 60)
            {
                if (minutesDiference % 60 >= 10)
                {
                    Console.WriteLine($"{minutesDiference / 60}:{minutesDiference % 60} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutesDiference / 60}:0{minutesDiference % 60} hours before the start");
                }
            }
            else if (minutesDiference > -60 && minutesDiference < 0)
            {
                Console.WriteLine($"{Math.Abs(minutesDiference)} minutes after the start");
            }
            else if (minutesDiference <= -60)
            {
                if (minutesDiference % 60 <= -10)
                {
                    Console.WriteLine($"{Math.Abs(minutesDiference) / 60}:{Math.Abs(minutesDiference) % 60} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(minutesDiference) / 60}:0{Math.Abs(minutesDiference) % 60} hours after the start");
                }
            }
        }
    }
}
