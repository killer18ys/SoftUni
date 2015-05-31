using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int element = 2;
            int n = 1000;

            for (int i = 0; i < n; i++)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element);
                }
                else
                {
                    Console.Write((element * -1));
                }

                if (i < n - 1)
                {
                    Console.Write(", ");
                }

                element++;
            }

            Console.WriteLine();
        }
    }
}
