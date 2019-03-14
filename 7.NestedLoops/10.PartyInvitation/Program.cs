using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PartyInvitation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            bool isValid = true;

            double totalNamesCount = 0;
            double validNamesCount = 0;
            double inValidNamesCount = 0;

            while ((name = Console.ReadLine()) != "Statistic")
            {
                isValid = true;
                totalNamesCount++;

                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        Console.WriteLine("Invalid name!");
                        inValidNamesCount++;
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    validNamesCount++;

                    name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();
                    Console.WriteLine(name);
                }
            }
            double peobleComing = (validNamesCount / totalNamesCount) * 100;
            double peopleNotComing = (inValidNamesCount / totalNamesCount) * 100;

            Console.WriteLine($"Valid names are {peobleComing:f2}% from {totalNamesCount} names.");
            Console.WriteLine($"Invalid names are {peopleNotComing:f2}% from {totalNamesCount} names.");
        }
    }
}
