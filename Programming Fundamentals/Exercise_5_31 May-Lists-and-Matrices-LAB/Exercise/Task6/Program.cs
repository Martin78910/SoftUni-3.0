using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //          var nums = Console.ReadLine().Split(' ')
            //.Select(int.Parse).ToList();
            //          nums.Sort();
            //          var pos = 0;
            //          while (pos < nums.Count)
            //          {
            //              int num = nums[pos], count = 1;
            //              while (pos + count < nums.Count &&
            //                     nums[pos + count] == num)
            //                  count++;
            //              pos = pos + count;
            //              Console.WriteLine($"{num} -> {count}");

            var nums = Console.ReadLine().Split(' ')
  .Select(int.Parse).ToList();
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
            {
                int num = nums[pos], count = 1;
                while (pos + count < nums.Count &&
                       nums[pos + count] == num)
                    count++;
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }


        }

    }
 }

