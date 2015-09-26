using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', ',', '.', '!', '?'};
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string reversedWord;
            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                reversedWord = Reverse(word);

                if (word.Equals(reversedWord))
	            {
		            palindromes.Add(word);
	            }

            }

            Console.WriteLine(string.Join(", ", palindromes));

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
