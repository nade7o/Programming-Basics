using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxSumName = 0;
            string currentName = string.Empty;

            while (name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum >= maxSumName)
                {
                    maxSumName = sum;
                    currentName = name;
                }

                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {currentName} - {maxSumName}!");
        }
    }
}
