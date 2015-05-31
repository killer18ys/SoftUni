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
            string nStars = new string(s, n * 2);
            string nSpaces = new string(space, n * 2);

            Console.WriteLine(nStars + nSpaces + nStars);

        }
    }
}
