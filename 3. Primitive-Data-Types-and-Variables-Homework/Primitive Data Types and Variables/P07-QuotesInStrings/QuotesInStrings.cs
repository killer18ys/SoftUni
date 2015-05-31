using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            String s1 = "The \"use\" of quotations causes difficulties.";
            String s2 = @"The ""use"" of quotations causes difficulties.";


            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
