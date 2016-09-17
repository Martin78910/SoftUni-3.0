using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ').ToArray();
            Random rnd = new Random();
            for (int first = 0; first < words.Length-1; first++)
            {
                var second = rnd.Next(0,words.Length);
                var old = words[first];
                words[first] =words[second] ;
                words[second] = old;

            }
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
