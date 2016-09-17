using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Task17
    {
        static void Main(string[] args)
        {
           
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                if (n>Int64.MaxValue)
                {
                     Console.WriteLine("{0} can't fit in any type", n);
                }
                else if (true)
                {
                    Console.WriteLine("{0} can fit in:", n);
                    if (n >= -128 && n <= 127)
                    {
                        Console.WriteLine("* sbyte");
                    }

                    if (n >= 0 && n <= 255)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (n >= Int16.MinValue && n <= Int16.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (n >= 0 && n <= 65535)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (n >= Int32.MinValue && n <= Int32.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (n >= 0 && n <= 4294967295)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (n >= Int64.MinValue && n <= Int64.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }

                    else
                    {
                        Console.WriteLine("{0} can't fit in any type", n);
                    }
                }
               
                    
           
        }
    }
}
