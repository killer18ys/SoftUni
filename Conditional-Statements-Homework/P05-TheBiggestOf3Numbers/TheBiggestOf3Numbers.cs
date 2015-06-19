using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());


            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number is {0}", b);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }

            }

        }
    }
}
