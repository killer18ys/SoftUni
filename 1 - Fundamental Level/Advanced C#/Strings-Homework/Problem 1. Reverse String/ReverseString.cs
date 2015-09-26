using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Reverse_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            char[] str = input.ToArray<char>();
            char[] reversed = new char[str.Length];


            for (int i =  str.Length - 1, k = 0; 0 <= i ; i--, k++)
            {
                reversed[k] = str[i];
            }

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
