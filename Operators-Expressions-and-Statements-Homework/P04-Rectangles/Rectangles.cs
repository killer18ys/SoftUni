﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double  width = double.Parse(Console.ReadLine());
            double  height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
    }
}
