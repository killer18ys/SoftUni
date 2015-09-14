using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int stepsNum = n * 8 / step + 1;
            int[] steps = new int[stepsNum];

            for (int i = 0; i < stepsNum; i++)
            {
                steps[i] = 1 + step * i;
            }


            int lengthOfBytes = n * 8;
            int changer;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < stepsNum; k++)
                {
                    if (steps[k] > 8 * i && steps[k] <= 8 * (i + 1))
                    {
                        if (k == 0)
                        {
                            changer = 1 << 7;
                        }
                        else
                        {
                            changer = 1 << 8 * (i+1) - steps[k];
                        }


                        if ((numbers[i] & changer) != 0)
                        {
                            numbers[i] = numbers[i] & ~changer;
                        }
                        else
                        {
                            numbers[i] = numbers[i] | changer;
                        }
                    } 
                }
            }



            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
