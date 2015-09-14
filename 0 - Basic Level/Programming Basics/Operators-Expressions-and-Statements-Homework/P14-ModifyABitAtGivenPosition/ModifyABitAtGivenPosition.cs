using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int mask = 1 << p;

            if (v == 1)
            {
                n = n | mask;
            }
            else
            {
                n = n & ~mask;
            }

            Console.WriteLine(n);
        }
    }
}
