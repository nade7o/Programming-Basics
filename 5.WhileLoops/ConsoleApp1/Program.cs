using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int poor = int.Parse(Console.ReadLine());
            double count = 0;
            double total = 0;
            int poorCount = 0;
            string lastTask = string.Empty;

            while (poor != poorCount)
            {
                string task = Console.ReadLine();
                if (task == "Enough")
                {
                    double average = total / count;
                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {count}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                lastTask = task;
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorCount++;
                }
                total += grade;
                count++;
            }
            if (poor == poorCount)
            {
                Console.WriteLine($"You need a break, {poor} poor grades.");
            }
        }
    }
}