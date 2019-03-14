using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double scholarshipSocial = 0.35 * salary;
            double scholarshipExcellent = grade * 25;

            if (grade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (income < salary && grade > 4.5 && grade < 5.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipSocial));
            }

            else if (income < salary && grade >= 5.50)
            {
                if (scholarshipExcellent < scholarshipSocial)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipSocial));
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipExcellent));
                }
            }
            else if (income >= salary && grade >= 5.50)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipExcellent));
            }
            else if (income >= salary && grade >= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
