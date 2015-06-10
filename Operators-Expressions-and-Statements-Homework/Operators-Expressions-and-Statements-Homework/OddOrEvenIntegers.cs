using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            if (n % 2 != 0){
                Console.WriteLine("{0} is Odd", n);
            }
            else{
                Console.WriteLine("{0} is Even", n);
            }

        }
    }
}
