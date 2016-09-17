using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Task15
    {
        static void Main(string[] args)
        {
            float numberA = float.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            bool equal = Math.Abs(numberA - numberB)<0.000001;
            Console.WriteLine(equal);
           
        }
    }
}
