using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            bool isTrue = bool.Parse(a);
            if (isTrue==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
