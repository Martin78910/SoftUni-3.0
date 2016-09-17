using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Task23
    {
        static void Main(string[] args)
        {

            long digit = long.Parse(Console.ReadLine());
            bool isPrime = true;
            if (digit==1 || digit==0)
            {
                isPrime = false;
            }
           
            for (int i = 2; i <= Math.Sqrt(digit); i++)
            {
                if (digit % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime);
        }

    }
}



