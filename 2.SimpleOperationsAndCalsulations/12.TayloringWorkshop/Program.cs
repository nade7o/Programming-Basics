using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double covers = tables * (tableLenght + (2 * 0.30)) * (tableWidth + (2 * 0.30));
            double careta = tables * (tableLenght / 2) * (tableLenght / 2);

            double sumUSD = (covers * 7) + (careta * 9);
            double sumBGN = sumUSD * 1.85;

            Console.WriteLine("{0:f2} USD", sumUSD);
            Console.WriteLine("{0:f2} BGN", sumBGN);
        }
    }
}