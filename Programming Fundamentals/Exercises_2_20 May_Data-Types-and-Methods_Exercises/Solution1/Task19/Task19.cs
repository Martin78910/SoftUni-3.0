using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Task19
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }

   
        static void GetMax(params int [] numbers)
        {
            foreach (var number in numbers)
                numbers.Max();
            Console.WriteLine(numbers.Max());
        }
       
    }
}
