using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            sbyte firstNumber = sbyte.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());
            short thirdNumber =short.Parse(Console.ReadLine());
            ushort fourthNumber = ushort.Parse(Console.ReadLine());
            uint fifthNumber = uint.Parse(Console.ReadLine());
            int sixthNumber = int.Parse(Console.ReadLine());
            long seventhNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n",firstNumber,secondNumber,thirdNumber,fourthNumber,fifthNumber,sixthNumber,seventhNumber );
        }
    }
}
