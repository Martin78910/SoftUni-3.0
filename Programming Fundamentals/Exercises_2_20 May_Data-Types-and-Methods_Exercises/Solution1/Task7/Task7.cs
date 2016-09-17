using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.Write("Before:\na = {0}\nb = {1}\n", a,b);
            int c = b;
            b = a;
            a = c;
            Console.Write("After:\na = {0}\nb = {1}\n", a,b);
        }
    }
}
