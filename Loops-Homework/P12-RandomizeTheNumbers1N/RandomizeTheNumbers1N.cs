using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int number;

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                number = rand.Next(min, max+1);
                Console.WriteLine(number);
            }


        }
    }
}
