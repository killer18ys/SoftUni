﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater: {0}", Math.Max(a,b));
        }
    }
}
