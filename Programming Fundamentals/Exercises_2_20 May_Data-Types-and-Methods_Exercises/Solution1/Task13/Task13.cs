using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Task13
    {
        static void Main(string[] args)
        {
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());
            if ((symbol=='a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if ((symbol >= '0') && (symbol<= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
	
        }
    }
}
