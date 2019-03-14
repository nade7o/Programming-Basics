using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks

{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBookName = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());
            string bookName = "";
            int times = 0;

            while (bookName != searchedBookName && times <= libraryCapacity )
            {
                bookName = Console.ReadLine();
                times++;
            }
                if (bookName == searchedBookName && times <= libraryCapacity)
                {
                times--;
                    Console.WriteLine($"You checked {times} books and found it.");
                    
                }

                else
                {
                times--;
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {times} books.");
                }
            
        }
    }
}
