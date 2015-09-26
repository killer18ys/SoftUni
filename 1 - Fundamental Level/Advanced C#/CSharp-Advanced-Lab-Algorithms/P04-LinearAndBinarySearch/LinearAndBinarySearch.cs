using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_LinearAndBinarySearch
{
    class LinearAndBinarySearch
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int searchedElement = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(numbers, searchedElement));

        }

        static int BinarySearch(int[] array, int element)
        {
            int indexOfElement = -1;
            int arrLenght = array.Length;
            int min = 0;
            int middleElementIndex;
            int max = arrLenght - 1;
           

            Array.Sort(array);
            middleElementIndex = (arrLenght / 2); 

            while (true)
            {
                if (array[middleElementIndex] < element )
                {
                    middleElementIndex -= middleElementIndex / 2; 
                }
                else if (array[middleElementIndex] > element)
                {
                    middleElementIndex += middleElementIndex / 2;

                    min = middleElementIndex + 1;
                    middleElementIndex = (min + max) / 2;
                }
                else
                {
                    indexOfElement = middleElementIndex;
                    break;
                }



            }   


            return indexOfElement;
        }
    }
}
