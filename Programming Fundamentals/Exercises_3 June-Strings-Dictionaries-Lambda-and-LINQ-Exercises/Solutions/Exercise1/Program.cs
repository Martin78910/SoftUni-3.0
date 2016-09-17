using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            for (int i = text.Length-1; i >= 0; i--)
            {
                char ch = text[i];
                Console.Write("{0}", text[i] );
            }
            Console.WriteLine();
        }
    }
}
