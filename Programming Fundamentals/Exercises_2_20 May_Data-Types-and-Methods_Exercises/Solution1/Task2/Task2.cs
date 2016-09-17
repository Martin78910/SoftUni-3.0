using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}\n{1}\n{2}\n", firstNumber, secondNumber, thirdNumber);
        }
    }
}
