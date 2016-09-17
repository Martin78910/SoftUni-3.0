using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var arr = new decimal[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                arr[i] = SumNums(arr, i-k, i-1);
              
            }
            Console.WriteLine("Sequence:");
            Console.WriteLine(String.Join(" ", arr));
                      
        }

     
        private static decimal SumNums(decimal[] arr, int startIndex, int endIndex)
        {
            decimal sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0) sum += arr[i];
            }
                    return sum;
                }

            }
        }
    

