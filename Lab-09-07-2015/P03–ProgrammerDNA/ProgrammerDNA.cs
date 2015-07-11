using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ProgrammerDNA
{
    class ProgrammerDNA 
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int startLetterNum = char.Parse(Console.ReadLine());
            char dot = '.';

            string threeDots = new string(dot, 3);
            string twoDots = new string(dot, 2);

            for (int i = 1; i <= n; i++)
			{
			    if (i % 7 == 1)
	            {
                    if (i != 1)
                    {
                        startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                    }
                    Console.WriteLine(threeDots + (char)startLetterNum + threeDots);
	            }
                else if (i % 7 == 2)
                {
                    Console.Write(twoDots);
                    for (int k = 1; k <= 3; k++)
                    {
                        startLetterNum = (startLetterNum < 71)? startLetterNum + 1 : 65;
                        Console.Write((char)startLetterNum);
                    }  
                    Console.WriteLine(twoDots);
                }
                else if (i % 7 == 3)
                {
                    Console.Write(dot);
                    for (int k = 1; k <= 5; k++)
                    {
                        startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                        Console.Write((char)startLetterNum);
                    }
                    Console.WriteLine(dot);
                }
                else if (i % 7 == 4)
                {
                    for (int k = 1; k <= 7; k++)
                    {
                        startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                        Console.Write((char)startLetterNum);
                    }
                    Console.WriteLine();
                }
                else if (i % 7 == 5)
                {
                    Console.Write(dot);
                    for (int k = 1; k <= 5; k++)
                    {
                        startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                        Console.Write((char)startLetterNum);
                    }
                    Console.WriteLine(dot);
                }
                else if (i % 7 == 6)
                {
                    Console.Write(twoDots);
                    for (int k = 1; k <= 3; k++)
                    {
                        startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                        Console.Write((char)startLetterNum);
                    }
                    Console.WriteLine(twoDots);
                }
                else if (i % 7 == 0)
                {
                    startLetterNum = (startLetterNum < 71) ? startLetterNum + 1 : 65;
                    Console.WriteLine(threeDots + (char)startLetterNum + threeDots); 
                }
			}

        }
    }
}

