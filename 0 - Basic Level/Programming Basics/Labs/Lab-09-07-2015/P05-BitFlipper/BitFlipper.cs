using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BitFlipper
{
    class BitFlipper
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int endBit = 62;
            while (endBit > 0)
            {
                endBit--;
                ulong last3Bits = (n >> endBit) & 7;
                if (last3Bits == 0 || last3Bits == 7)
                {
                    n = n ^ ((ulong)7 << endBit);
                    endBit -= 2;
                }
            }

            Console.WriteLine(n);
        }
    }
}
