using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGabi
{
    class Program
    {
        static void Main(string[] args)
        {

            int steps = 0;
            string command;

            while (steps < 10000)
            {
                command = Console.ReadLine();
                if (command == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    steps += stepsHome;
                    break;
                }
                else
                {
                    int stepsMade = int.Parse(command);
                    steps += stepsMade;
                }
            }

            int difference = 10000 - steps;
            if (difference <= 0)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}

