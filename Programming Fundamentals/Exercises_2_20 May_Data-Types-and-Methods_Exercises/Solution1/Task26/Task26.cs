using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Task26
    {
        static void Main(string[] args)
        {

          
            int n = int.Parse(Console.ReadLine());
            
             System.Numerics.BigInteger factorial = 1;
            
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                
            }
            Console.WriteLine("{0}", factorial);

        }
    }
}
