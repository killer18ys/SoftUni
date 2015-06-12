using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            bool isOne = false;

            int mask = 1 << p;

            if ((n & mask) != 0)
            {
                isOne = true;
            }


            Console.WriteLine(isOne);
        }
    }
}
