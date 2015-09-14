using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int maxNum = 0;
            int num;
            int sum = 0;
            bool isMax = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                num =  int.Parse(numbers[i]);

                if (maxNum < num)
                {
                    maxNum = num;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                num = int.Parse(numbers[i]);

                if (maxNum >= num)
                {
                    if (maxNum == num && isMax)
                    {
                        isMax = false;
                        continue;
                    }

                    sum += num;
                } 
                
            }

            if (sum == maxNum)
            {
                Console.WriteLine("Yes, sum={0}", sum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Max(sum, maxNum) - Math.Min(sum, maxNum));
            }

        }
    }
}
