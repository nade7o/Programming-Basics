using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForRest = int.Parse(Console.ReadLine());
            double perifernachastPrice = double.Parse(Console.ReadLine());
            double programPrice = double.Parse(Console.ReadLine());
            double frapePrice = double.Parse(Console.ReadLine());

            timeForRest = timeForRest - 5;
            timeForRest = timeForRest - ((3 * 2) + (2 * 2));

            perifernachastPrice = perifernachastPrice * 3;
            programPrice = programPrice * 2;
            double moneySpent = perifernachastPrice + programPrice + frapePrice;

            Console.WriteLine("{0:f2}", moneySpent);
            Console.WriteLine(timeForRest);
        }
    }
}
