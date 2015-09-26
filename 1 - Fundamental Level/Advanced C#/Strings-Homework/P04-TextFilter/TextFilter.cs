using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', ',' };
            string[] banWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();
 
            foreach (string word in banWords)
            {
                inputText = inputText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(inputText);
        }
    }
}
