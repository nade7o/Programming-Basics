using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradesCount = int.Parse(Console.ReadLine());
            string enter="";
            double gradesSum = 0;
            int times = 0;
            int poorGrades = 0;
            double grade = 0;
            string lastTask = String.Empty;

            while (enter != "Enough" && poorGrades < badGradesCount )
            {
                enter = Console.ReadLine();
                
                if (enter != "Enough")
                {
                    
                    grade = double.Parse(Console.ReadLine());
                    times++;
                }
                if (grade >= 5)
                {
                    gradesSum += grade;
                    
                }
                else
                {
                    poorGrades++;
                }
            }
            double average = gradesSum / times;

            if (enter == "Enough" && poorGrades < badGradesCount)
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine("Number of problems: {0}", times);
                Console.WriteLine("Last problem: {0}", lastTask);
            }
            

            else if (poorGrades >= badGradesCount)
            {
                Console.WriteLine("You need a break, {0} poor grades.", poorGrades);
            }
        }
    }
}
