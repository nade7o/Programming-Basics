using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConventor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine().ToLower();
            string outputUnit = Console.ReadLine().ToLower();


            if (inputUnit == "mm")
            {
                number = number / 1000;
            }
            else if (inputUnit == "cm")
            {
                number = number / 100;
            }
            else if (inputUnit == "mi")
            {
                number = number / 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                number = number / 39.3700787;
            }
            else if (inputUnit == "km")
            {
                number = number / 0.001;
            }
            else if (inputUnit == "ft")
            {
                number = number / 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                number = number / 1.0936133;
            }


            if (outputUnit == "mm")
            {
                number = number * 1000;
            }
            else if (outputUnit == "cm")
            {
                number = number * 100;
            }
            else if (outputUnit == "mi")
            {
                number = number * 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                number = number * 39.3700787;
            }
            else if (outputUnit == "km")
            {
                number = number * 0.001;
            }
            else if (outputUnit == "ft")
            {
                number = number * 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                number = number * 1.0936133;
            }

            Console.WriteLine("{0:F8}", number);
        }
    }
}
