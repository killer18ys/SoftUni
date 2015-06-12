using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if ((n % 5) == 0 && (n % 7) == 0 && n != 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


        }
    }
}
