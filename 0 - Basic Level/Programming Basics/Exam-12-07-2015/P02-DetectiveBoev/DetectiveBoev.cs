using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();

            char[] decryptedMessage = new char[encryptedMessage.Length];

            int mask = maskGenerator(secretWord);

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if ((encryptedMessage[i] % mask) == 0)
	           {
		            decryptedMessage[i] =  (char)(encryptedMessage[i] + mask);
	           }
               else
               {
                    decryptedMessage[i] =  (char)(encryptedMessage[i] - mask);
               }
            }

            for (int i = decryptedMessage.Length - 1; i >= 0; i--)
            {
                Console.Write(decryptedMessage[i]);
            }

            Console.WriteLine();
        }

        static int maskGenerator(string secretWord)
        {
            int mask = 0;
            int lastDigit;
            int newMask = 0;

            for (int i = 0; i < secretWord.Length; i++)
            {
                mask += (int)secretWord[i];
            }

            while (mask != 0)
            {
                lastDigit = mask % 10;
                mask /= 10;

                newMask += lastDigit;

                if ((mask == 0) && newMask > 10)
                {
                    mask = newMask;
                    newMask = 0;
                }
            }

            return newMask;
        }
    }
}
