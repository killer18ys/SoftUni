using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbers =  input.Split(' ');
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
