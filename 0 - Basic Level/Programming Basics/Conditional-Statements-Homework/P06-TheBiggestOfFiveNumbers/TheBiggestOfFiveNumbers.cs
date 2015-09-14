using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double number;
            double max = double.MinValue;

            for (int i = 0; i < 5; i++)
            {
                number = double.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The biggest number is {0}.", max);
        }
    }
}
