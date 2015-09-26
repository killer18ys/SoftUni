using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray<char>();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetEscapeSequence(input[i]));
            }
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
