using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_GameOfBits
{
    class GameOfBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            string input = "";
            uint lastExchange = number;

            while (input != "Game Over!")
            {
                input = Console.ReadLine();

                if (input == "Game Over!")
                {
                    Console.WriteLine("{0} -> {1}", lastExchange, CountOneBits(lastExchange));
                }
                else
                {
                    lastExchange = BitExtractor(lastExchange, input);
                }

            }

        }

        
        static uint BitExtractor(uint number, string command)
        {
            uint newNumber = 0;
            uint extractedNum = 0;
            int startNum = (command == "Odd") ? 30 : 31;


            for (int i = startNum; i >= 0; i -= 2)
            {
                newNumber = number & (uint)(1 << i);

                if (newNumber == 0)
	            {
		            extractedNum = extractedNum << 1;
	            }
                else
                {
                    extractedNum = extractedNum << 1;
                    extractedNum |= 1;
                }             
            }


            return extractedNum;
        }

        static uint CountOneBits(uint number)
        {
            uint nBits = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((number & (uint)(1 << i)) != 0)
                {
                    nBits +=1;
                }
            }

            return nBits;
        }
    }
}
