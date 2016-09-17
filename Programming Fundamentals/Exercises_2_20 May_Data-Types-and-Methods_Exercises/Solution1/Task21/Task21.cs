using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = decimal.Parse(Console.ReadLine());
            string reversedStr = new string(d.ToString().Reverse().ToArray());
            decimal reversedDouble;
            if (decimal.TryParse(reversedStr, out reversedDouble))
            {
                Console.WriteLine(reversedDouble);
            }
            else
            {
                // unable to reverse the double
            }
        }
    }
}
