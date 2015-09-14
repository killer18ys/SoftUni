using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            char s = '*';
            char space = ' ';
            char dash = '|';
            char fSlash = '/';

            int n = int.Parse(Console.ReadLine());

            string nStars = new string(s, 2 * n);
            string nSpaces = new string(space, n);
            string nFSlash = new string(fSlash, 2 * n - 2);
            string nDash = new string(dash, n);
            string star = new string(s, 1);

            int nLens = (n - 3) / 2;

            Console.WriteLine(nStars + nSpaces + nStars);

            for (int i = 0; i < nLens; i++)
            {
                Console.WriteLine(star + nFSlash + star + nSpaces + star + nFSlash + star);
            }

            Console.WriteLine(star + nFSlash + star + nDash + star + nFSlash + star);

            for (int i = 0; i < nLens; i++)
            {
                Console.WriteLine(star + nFSlash + star + nSpaces + star + nFSlash + star);
            }

            Console.WriteLine(nStars + nSpaces + nStars);

        }
    }
}
