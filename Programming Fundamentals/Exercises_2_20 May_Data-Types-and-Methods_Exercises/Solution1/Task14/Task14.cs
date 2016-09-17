using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Task14
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(a, 16);
            string upper = hexadecimal.ToUpper();
            string binary = Convert.ToString(a, 2);
            Console.WriteLine(upper);
            Console.WriteLine(binary);

            
        }
    }
}
