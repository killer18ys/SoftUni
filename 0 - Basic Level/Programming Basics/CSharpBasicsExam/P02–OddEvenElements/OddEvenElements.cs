using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double number;

            bool isOneNum = numbers.Length < 2 ? true : false;


            for (int i = 0; i < numbers.Length; i++)
            {
                number = double.Parse(numbers[i]);

                if (i % 2 == 0)
                {
                    oddSum += number;
                    oddMin = number < oddMin ? number : oddMin;
                    oddMax = number > oddMax ? number : oddMax;
                }
                else
                {
                    evenSum += number;
                    evenMin = number < evenMin ? number : evenMin;
                    evenMax = number > evenMax ? number : evenMax;
                }

            }
            if (isOneNum)
            {
                Console.WriteLine("OddSum={0:G}, OddMin={1:G}, OddMax={2:G}, EvenSum={3:G}, EvenMin={4:G}, EvenMax={5:G}", oddSum, oddMin, oddMax, "No", "No", "No");
            }
            else
            {
                Console.WriteLine("OddSum={0:G}, OddMin={1:G}, OddMax={2:G}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
            
        }
    }
}
