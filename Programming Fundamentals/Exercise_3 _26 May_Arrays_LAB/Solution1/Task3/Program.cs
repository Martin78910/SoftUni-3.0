using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = new int[n];
            for (int i = 0; i < n; i++)
                nums[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("First = {0}", nums[0]);
            Console.WriteLine("Last = {0}", nums[n-1]);
            Console.WriteLine("Average = {0:f2}",(double) nums.Sum()/ n);
        }
    }
}
