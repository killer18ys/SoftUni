using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_PrimeFactorization
{
    class PrimeFactorization
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int divisor = 2;
            List<int> primeFactors = new List<int>();


            while (n > 2) // ex. n = 12;
            {
                if ((n % divisor) == 0)
                {
                    n = n / divisor;
                    primeFactors.Add(divisor);
                }
                else
                {
                    divisor++;
                }
            }

            int count = 1;

            Console.Write("{0} = ", number);

            foreach (int primefactor in primeFactors)
            {
                Console.Write("{0}", primefactor);


                if (count != primeFactors.Count())
                {
                    Console.Write(" * ");
                }

                count++;
            }

            Console.WriteLine();
        }
    }
}
