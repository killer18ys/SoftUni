using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SortArrayWithSelectionSort
{
    class SortArrayWithSelectionSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int minNum = int.MaxValue;
            int tempSmallest;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    numbers = swipe(numbers, i, 0);
                    minNum = numbers[i];
                }
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                tempSmallest = findSmallest(numbers.Skip(i).ToArray());
                numbers = swipe(numbers, i, Array.FindIndex(numbers, item => item == tempSmallest));
            }
           

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.Write("{0} ",number);
            }

            Console.WriteLine();
        }

        static int findSmallest(int[] array)
        {
            int minValue = int.MaxValue;

            foreach (int number in array)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            return minValue;
        }


        static int[] swipe(int[] array, int firstPosition, int secondPosition)
        {
            int temp;

            temp = array[firstPosition];
            array[firstPosition] = array[secondPosition];
            array[secondPosition] = temp;

            return array;
        }
    }
}
