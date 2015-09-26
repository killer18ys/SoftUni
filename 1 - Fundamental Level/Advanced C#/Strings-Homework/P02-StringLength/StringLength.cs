using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder str = new StringBuilder();

            int strLength = input.Length;

            if (strLength >= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    str.Append(input[i]);
                }
            }
            else
            {
                str.Append(input);
                str.Append(new string('*', 20 - strLength));
            }

            Console.WriteLine(str.ToString());
        }
    }
}
