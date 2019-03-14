using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentSandPlants = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double aquariumLitres = volume * 0.001;
            double percent = percentSandPlants * 0.01;


            Console.WriteLine($"{(aquariumLitres * (1 - percent)):F3}");
        }
    }
}
