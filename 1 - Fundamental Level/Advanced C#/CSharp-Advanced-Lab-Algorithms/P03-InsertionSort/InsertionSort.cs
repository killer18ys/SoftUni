using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] array = input.Split(' ').Select(int.Parse).ToArray();


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                   

                }
            }

            Console.WriteLine(string.Join(", ", array));

        }
    }
}
