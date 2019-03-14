using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());

                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
