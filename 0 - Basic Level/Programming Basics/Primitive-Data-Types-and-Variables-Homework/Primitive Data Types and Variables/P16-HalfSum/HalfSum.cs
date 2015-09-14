using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;

            for(int i = 0; i < n; i++)
            {
                firstSum += int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                secondSum += int.Parse(Console.ReadLine());
            }


            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, Sum = {0}", firstSum);
            }
            else
            {
                int diff = Math.Max(firstSum, secondSum) - Math.Min(firstSum, secondSum);
                Console.WriteLine("No, Diff = {0}", diff);
            }

        }
    }
}
