using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int[] count = new int[text.Max() + 1];
            foreach (var letter in text)
            {
                count[letter]++;
            }
            for (char i =(char)0; i < count.Length; i++)
            {
                if (count[i]!=0)
                {
                    Console.WriteLine("{0} ->{1}",i,count[i]);
                }
            }
            
        }
    }
}
