using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SummertimeForProgrammers
{
    class SummertimeForProgrammers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char star = '*';
            char at = '@';
            char space = ' ';

            string top = new string(star, n + 1);
            string bottom = new string(star, 2 * n);
            int count = 0;

            Console.WriteLine(new string(space, (n - 1) / 2) + top);
            for (int i = 0; i < n-1; i++)
            {
                if (i <= (n-1)/2)
                {
                    Console.WriteLine(new string(space, (n - 1) / 2) + star + new string(space, n - 1) + star + new string(space, (n - 1) / 2));
                }
                else
                {
                    count++;
                    Console.WriteLine(new string(space, (n - 1) / 2 - count) + star + new string(space, n - 1 + count *2) + star);
                }
            }

            for (int i = 0; i < n*2; i++)
            {
                if (i < n )
                {
                    Console.WriteLine(star + new string(dot, 2 * n - 2) + star);
                }
                else
                {
                    Console.WriteLine(star + new string(at, 2 * n - 2) + star);
                }
            }
            Console.WriteLine(bottom);

        }
    }
}
