﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
  .Select(int.Parse).ToArray();
            var count = 0;
for (int i = 0; i < arr.Length; i++)
  for (int j = i + 1; j < arr.Length; j++)
  {
    int a = arr[i];
    int b = arr[j];
    int sum = a + b;
    if (arr.Contains(sum))
      Console.WriteLine("{0} + {1} == {2}", a,b,sum);
    count++;
 
    
}
if (count == 0)
{
    Console.WriteLine("No");
}
        }
    }
    
}
