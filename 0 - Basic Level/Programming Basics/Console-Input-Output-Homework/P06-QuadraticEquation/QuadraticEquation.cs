using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d, x1, x2;

            d = Math.Pow(b, 2) - 4 * (a * c);

            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (d == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", (-b) / (2 * a));

            }
            else
            {
                Console.WriteLine("no real roots");
            }

            


        }
    }
}
