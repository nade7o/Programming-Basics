using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = string.Empty;

            while (presentation != "Finish")
            {
                presentation = Console.ReadLine();
                
                int gradeCount = 0;
                double presentationAverage = 0;
                double presentationAverageSum = 0;
                int count = 0;

                if (presentation == "Finish")
                {
                    double studentAssesment = presentationAverageSum / gradeCount ;
                    Console.WriteLine($"Student's final assesment is {studentAssesment}.");
                }
                
                
                while (gradeCount < n)
                {
                  double grade = double.Parse(Console.ReadLine());
                    double gradeSum = 0;
                    gradeSum += grade;
                    gradeCount ++;
                    presentationAverage = gradeSum / gradeCount;
                    presentationAverageSum += presentationAverage;
                    Console.WriteLine($"{presentation} - {presentationAverage}.");
                }
                
                
            }
        }
    }
}
