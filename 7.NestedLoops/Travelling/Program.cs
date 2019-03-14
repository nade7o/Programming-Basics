using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            while (destination != "End")
            {
                
                double budget = double.Parse(Console.ReadLine());
                double sumSave = 0;

                while (sumSave < budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    sumSave += sum;
                    if (sumSave >= budget)
                    {
                        Console.WriteLine("Going to {0}!", destination);
                        break;
                    }

                }
                destination = Console.ReadLine();
            }

        }
    }
}
