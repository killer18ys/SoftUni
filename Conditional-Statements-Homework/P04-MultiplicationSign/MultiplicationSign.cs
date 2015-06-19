using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());


            if ((a * b * c) < 0)
            {
                Console.WriteLine("-");
            }
            else if ((a * b * c) > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
