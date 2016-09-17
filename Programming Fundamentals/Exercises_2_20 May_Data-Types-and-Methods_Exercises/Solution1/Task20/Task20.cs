using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Task20
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            PrintLastDigit(number);

        }
        static void PrintLastDigit(long number)
        {
           
             long lastDigit = Math.Abs (number % 10);
             switch (lastDigit)
             {
                 case 0: Console.Write("zero"); break;
                 case 1: Console.Write("one"); break;
                 case 2: Console.Write("two"); break;
                 case 3: Console.Write("three"); break;
                 case 4: Console.Write("four"); break;
                 case 5: Console.Write("five"); break;
                 case 6: Console.Write("six"); break;
                 case 7: Console.Write("seven"); break;
                 case 8: Console.Write("eight"); break;
                 case 9: Console.Write("nine"); break;
                 default: Console.Write("Invalid number"); break;
             }
                
        }  
            
    }
           
}
    

