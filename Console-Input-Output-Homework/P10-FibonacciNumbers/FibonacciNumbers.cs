using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int prevNum = 0;
            int nextNum;
            int currNum = 1;

            string fibonacci = "0";

            for (int i = 1; i < n; i++)
            {
                nextNum = prevNum + currNum;
                currNum = prevNum;
                prevNum = nextNum;


                fibonacci += (nextNum).ToString();
            }

            Console.WriteLine(fibonacci);

        }
    }
}
