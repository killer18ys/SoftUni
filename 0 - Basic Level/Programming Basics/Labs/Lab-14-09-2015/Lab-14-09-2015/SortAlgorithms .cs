using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_09_2015
{
    class SortAlgorithms 
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();


            numbers = BubbleSort(numbers);

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] BubbleSort(int[] array)
        {

            int temp;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }
    }
}
