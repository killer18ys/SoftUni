using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number); 
            }
        }
    }
}
