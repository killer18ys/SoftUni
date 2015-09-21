using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    Console.Write("{0} ", words[i]);

                    if (i == words.Length - 2)
                    {
                        Console.Write("{0} ", words[i + 1]);
                        Console.WriteLine();
                    }
                 
                }
                else
                {
                    Console.Write("{0} ", words[i]);
                    Console.WriteLine();

                    if (i == words.Length - 2)
                    {
                        Console.Write("{0} ", words[i + 1]);
                        Console.WriteLine();
                    }
                }
            }
        }


    }
}
