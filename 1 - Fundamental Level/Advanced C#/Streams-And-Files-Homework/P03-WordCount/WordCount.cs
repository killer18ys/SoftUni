using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P03_WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string wordsFilePath = @"C:\Users\Killer18ys\Desktop\words.txt";
            string textFilePath = @"C:\Users\Killer18ys\Desktop\text.txt";
            string resultFilePath = @"C:\Users\Killer18ys\Desktop\result.txt";

            StreamReader wordsFileRead = new StreamReader(wordsFilePath);
            StreamReader textFileRead = new StreamReader(textFilePath);
            StreamWriter resultFileWrite = new StreamWriter(resultFilePath);

            Dictionary<string, int> wordCountDictionary = new Dictionary<string,int>();

            string word;
            using(wordsFileRead)
	        {
                while (wordsFileRead.Peek() >= 0)
	            {
	                 word = wordsFileRead.ReadLine().Trim();
                     wordCountDictionary.Add(word, 0);
	            }		        
	        }

            string[] wordsInLine;
            char[] parameters = {' ', ',', '?', '!', '.', '-'} ;

            using(textFileRead)
	        {
		        while (textFileRead.Peek() >= 0)
	            {
	               wordsInLine =  textFileRead.ReadLine().Split(parameters, StringSplitOptions.RemoveEmptyEntries);
                   foreach (string currWord in wordsInLine)
	               {
                       if (wordCountDictionary.ContainsKey(currWord.ToLower()))
	                    {
                            wordCountDictionary[currWord.ToLower()] += 1;
	                    }
	               }

	            }
	        }

            using(resultFileWrite)
	        {
                foreach (KeyValuePair<string, int> entry in wordCountDictionary.OrderByDescending(e => e.Value)) 
	            {
		            resultFileWrite.WriteLine("{0} - {1}", entry.Key, entry.Value);
	            }
	        }



        }
    }
}
