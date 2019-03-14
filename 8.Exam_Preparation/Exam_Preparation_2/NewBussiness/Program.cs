using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceWidth = int.Parse(Console.ReadLine());
            int spaceLenght = int.Parse(Console.ReadLine());
            int spaceHeight = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int spaceVolume = spaceWidth * spaceLenght * spaceHeight;
            int computersVolume = 0;

            while ((command = Console.ReadLine()) != "Done" && spaceVolume >= computersVolume)
            {
                int computers = int.Parse(command);
                computersVolume += computers;
                if (spaceVolume < computersVolume)
                {
                    int spaceNeeded = computersVolume - spaceVolume;
                    Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");
                }
            }
            if (command == "Done")
            {
                if (spaceVolume > computersVolume)
                {
                    int leftSpace = spaceVolume - computersVolume;
                    Console.WriteLine($"{leftSpace} Cubic meters left.");
                }
                return;
            }
           


        }
    }
}
