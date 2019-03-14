using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numGrades = 1;
            int fails = 0;
            double sum = 0;

            while (numGrades <= 12 && fails < 2)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    numGrades++;
                }
                else
                {
                    fails++;
                }
            }
            if (fails == 2)
            {
                Console.WriteLine($"{name} has been excluded at {numGrades} grade");
            }

            else
            {
                double average = sum / 12.00;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
