using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char star = '*';

            string afterMiddle = new string(dot, n) + new string(star, n) + new string(dot, n);
            string middle = new string(star, n * 3);

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(new string(dot, (n*3 - 1)/2) + star + new string(dot, (n*3 - 1)/2));
                }
                else
                {
                    Console.WriteLine(new string(dot, i) + star + new string(dot, (n * 3 - 3 - 2 * i) / 2) + star + new string(dot, (n * 3 - 3 - 2 * i) / 2) + star + new string(dot, i));
                }
            }

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.WriteLine(afterMiddle);
            }

            Console.WriteLine(middle);

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(afterMiddle);
            }

            for (int i = n-1; i >= 0 ; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(new string(dot, (n * 3 - 1) / 2) + star + new string(dot, (n * 3 - 1) / 2));
                }
                else
                {
                    Console.WriteLine(new string(dot, i) + star + new string(dot, (n * 3 - 3 - 2 * i) / 2) + star + new string(dot, (n * 3 - 3 - 2 * i) / 2) + star + new string(dot, i));
                }
            }

        }
    }
}
