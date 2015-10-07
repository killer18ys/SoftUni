using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P01_SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Za-z])\1+";
            Regex reg = new Regex(pattern);

            Console.WriteLine(reg.Replace(input, "$1"));
        }
    }
}
