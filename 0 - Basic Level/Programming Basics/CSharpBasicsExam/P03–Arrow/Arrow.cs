using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char numSign = '#';
            char dot = '.';

            int width = n * 2 - 1;

            string upperLine = new string(numSign, n);
            string upperSideOuterDots = new string(dot, (n - 1) / 2);
            string upperSideInnerDots = new string(dot, n - 2);
            string headSides = new string(numSign, (n + 1) / 2);
            string dots, innerArrow;

            Console.WriteLine(upperSideOuterDots + upperLine + upperSideOuterDots);
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(upperSideOuterDots + numSign + upperSideInnerDots + numSign + upperSideOuterDots); 
            }
            Console.WriteLine(headSides + upperSideInnerDots + headSides);

            for (int i = 1; i < n-1; i++)
            {
                dots = new string(dot, i);
                innerArrow = new string(dot, width - (i*2 + 2));

                Console.WriteLine(dots + numSign + innerArrow + numSign + dots);
            }

            dots = new string(dot, n-1);
            Console.WriteLine(dots + numSign + dots);

        }
    }
}
