using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int maxGoal = int.MinValue;
            string bestPlayerName = string.Empty;
            int goals = 0;


            while ((command = Console.ReadLine()) != "END" && goals < 10)
            {
               
                goals = int.Parse(Console.ReadLine());
                if (goals > maxGoal)
                {
                    maxGoal = goals;
                    bestPlayerName = command;
                }
                if (goals >= 10)
                {
                    break;
                } 
            }
            if (command == "END" || goals >= 10)
                {
                    Console.WriteLine($"{bestPlayerName} is the best player!");
                }
            if (goals >= 3)
                {
                    Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                }
            else 
                {
                    Console.WriteLine($"He has scored {goals} goals.");
                }
        }
    }
}
