using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main(string[] args)
        {
            long[] numbers = ParseInput(Console.ReadLine());
            List<long> switchedNumbers = new List<long>();
            long numberOne, numberTwo;

            Console.WriteLine(Convert.ToString(numbers[0], 2).PadLeft(63, '0'));
            Console.WriteLine(Convert.ToString(numbers[1], 2).PadLeft(63, '0'));
            int bitPosition = 64;

            for (int i = 1; i < numbers.Length; i+=2)
            {
                numberOne = numbers[i-1];
                numberTwo =  numbers[i];
                while (bitPosition != 0)
	            {
                    if (CheckBitAtPosition(numberOne, bitPosition) == 1)
                    {
                        if (CheckBitAtPosition(numberTwo, bitPosition) == 1)
                        {
                            //ostava edinica
                        }
                        else
                        {
                            //  purviq stava nula a vtoriq 1
                            numberOne = ChangeBitAtPosition(numberOne, bitPosition);
                            numberTwo = ChangeBitAtPosition(numberTwo, bitPosition);
                        }
                    }
                    else
                    {
                        if (CheckBitAtPosition(numberTwo, bitPosition) == 1)
                        {
                            //purviq stava 1 vtoriq stava 0
                            numberOne = ChangeBitAtPosition(numberOne, bitPosition);
                            numberTwo = ChangeBitAtPosition(numberTwo, bitPosition);
                        }
                        else
                        {
                            // i dvete ostavat 0
                        }
                    }
                    bitPosition -= 2;
	            }

                switchedNumbers.Add(numberOne);
                switchedNumbers.Add(numberTwo);


            }

            foreach (long  number in switchedNumbers)
            {
                Console.WriteLine(number);
                Console.WriteLine((ulong)~number >> 1);
            }

        }

        static long[] ParseInput(string input)
        {
            string[] inputs = input.Split(' ');
            long[] numbers = new long[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                numbers[i] = long.Parse(inputs[i]);
            }

            return numbers;
        }

        static int CheckBitAtPosition(long number, int position)
        {
            long mask = 1 << position;

            if ((number & mask) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static long ChangeBitAtPosition(long number, int position)
        {
            long mask = 1 << position;

            number = number ^ mask;

            return number;
        }
    }
}
