using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;

            if ((n & mask) != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
