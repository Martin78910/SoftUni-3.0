using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Task22
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
                return;//we use return to terminate the program if "n" is 0
            }

            int x1 = 0;
            int x2 = 1;
            
            
            int sum = 2;
        for (int i = 2; i < n; i++)
        {
            int x3 = x1 + x2;
          
            x1 = x2;
            x2 = x3;
            sum += x3;
        }
        Console.WriteLine(sum);
        }
            
    }
}


