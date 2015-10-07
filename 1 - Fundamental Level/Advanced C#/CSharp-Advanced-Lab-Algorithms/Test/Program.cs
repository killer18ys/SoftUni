using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int arrLength = 5;
            int offset = -3;
            int currIndex = 2;

            Console.WriteLine((currIndex + offset + arrLength) % arrLength);
        }
    }
}
