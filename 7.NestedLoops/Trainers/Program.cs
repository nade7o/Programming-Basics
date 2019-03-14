using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string text = string.Empty;
            double totalAverage = 0.00;
            int totalAverageCount = 0;

            while (text != "Finish")
            {
                text = Console.ReadLine();
                if (text == "Finish")
                {
                    totalAverage = totalAverage / totalAverageCount;
                    Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
                    break;
                }
                int gradesCount = 0;
                double gradesSum = 0;

                for (int i = 1; i <= juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesCount++;
                    gradesSum += grade;
                }
                double presentationAverage = gradesSum / gradesCount;
                totalAverage += presentationAverage;
                totalAverageCount++;
                Console.WriteLine($"{text} - {presentationAverage:f2}.");
        
            }
            
        }
    }
}
