using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0 )
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime = true;
                }
       
            }

            if (n == 2 || n == 3)
            {
                isPrime = true;
            }



            Console.WriteLine("{0} is {1}", n, isPrime ? "Prime" : "not Prime");

        }
    }
}
