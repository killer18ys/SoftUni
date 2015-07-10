using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool devBy3, devBy7;

            for (int i = 1; i <= n; i++)
            {
                devBy3 = (i % 3) == 0;
                devBy7 = (i % 7) == 0;

                if (!devBy3 && !devBy7)
                {
                    Console.Write(i + " ");
                }                
            }

            Console.WriteLine();
        }
    }
}
