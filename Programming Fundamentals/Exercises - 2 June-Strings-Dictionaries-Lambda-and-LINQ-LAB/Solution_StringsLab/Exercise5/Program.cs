using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            foreach (var w in words)
                text = text.Replace(w,
                   new string('*', w.Length));
            Console.WriteLine(text);

        }
    }
}
