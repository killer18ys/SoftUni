using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
