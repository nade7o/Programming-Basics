using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                char letter = word[letterIndex];
                switch (letter)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
