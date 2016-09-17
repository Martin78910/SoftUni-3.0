using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            Console.WriteLine(f);
          
        }
    }
}
