using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string strToFind = Console.ReadLine().ToLower();
            int count = 0;
            int sWordLength = strToFind.Length;
            int startPosition = 0;

               while(true)
               {
                   if (str.IndexOf(strToFind, startPosition) != -1)
                   {
                       startPosition = str.IndexOf(strToFind, startPosition) + 1;
                       count++;
                   }
                   else
                   {
                       break;
                   }

               
               }

            Console.WriteLine(count);
        }
    }
}
