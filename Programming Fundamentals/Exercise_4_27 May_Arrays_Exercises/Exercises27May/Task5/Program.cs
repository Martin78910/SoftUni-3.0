using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
           
            int index = 0;
            for (int i = 0; i < Math.Min(arrayOne.Length, arrayTwo.Length); i++)
            {
                index = i;
                if (arrayOne[i] != arrayTwo[i])
                {
                    break;
                }
            }
            if (arrayOne[index] < arrayTwo[index])
            {
                Console.WriteLine("{0}\n{1}", string.Join("",arrayOne), string.Join("",arrayTwo));
            }
            else if (arrayOne[index] > arrayTwo[index])
            {
                Console.WriteLine("{0}\n{1}", string.Join("",arrayTwo), string.Join("",arrayOne));
            }
            else if (index != arrayOne.Length - 1)
            {
                Console.WriteLine("{0}\n{1}", string.Join("",arrayTwo), string.Join("",arrayOne));
            }
            else if (index != arrayTwo.Length - 1)
            {
                Console.WriteLine("{0}\n{1}", string.Join("",arrayOne), string.Join("",arrayTwo));
            }
            else
            {
                Console.WriteLine("{0}\n{1}", string.Join("",arrayOne), string.Join("",arrayTwo));
            }
        }
    }
}