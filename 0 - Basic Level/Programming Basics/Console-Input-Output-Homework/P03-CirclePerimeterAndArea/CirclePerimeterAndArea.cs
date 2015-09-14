using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double perimeter;
            double area;

            perimeter = 2 * pi * r;
            area = pi * Math.Pow(r, 2);

            Console.WriteLine("Perimeter: {0:F2}", perimeter);
            Console.WriteLine("Area: {0:F2}", area);

        }
    }
}
