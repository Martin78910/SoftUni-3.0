﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Task18
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);

        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
