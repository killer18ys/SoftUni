using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_TheSieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 2;

           List<int> primes  = Enumerable.Range(2, n).ToList();
           primes.Sort();

           int next = primes.Skip(1).First();
           double maxPossible;
                while (true)
                {
                    maxPossible = Math.Pow(p, 2);

                    if ((p < maxPossible) || (p < n) )
	                {
		                if (true)
	            
	                }
                }
			}
            
        }
    }
}
