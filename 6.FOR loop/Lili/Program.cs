using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyPresent = 0;
            int sumMoneyPresent = 0;
            int toy = 0;

            for (int birthDay = 1; birthDay <= age; birthDay ++)
            {
                if (birthDay % 2 == 0)
                {
                    moneyPresent += 10;
                    sumMoneyPresent += moneyPresent;
                    sumMoneyPresent--;
                }
                else
                {
                    toy++;
                }
                
            }
           
            int moneyFromToys = toy * toyPrice;
            int moneySaved = sumMoneyPresent + moneyFromToys;
            
            if (moneySaved >= washerPrice)
            {
                double diff = moneySaved - washerPrice;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                double diff = washerPrice - moneySaved;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
