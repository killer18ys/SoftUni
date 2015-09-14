using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_EncryptTheMessages
{
    class EncryptTheMessages
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isOn = false;
            bool keepGoing = true;
            List<string> messages = new List<string>();

            while (keepGoing)
            {
                input = Console.ReadLine();
                keepGoing = (input != "end") && (input != "END");

                if (input == "start" || input == "START" || isOn == true)
                {
                    if (isOn && keepGoing && input != "")
                   {
                       messages.Add(EncryptMessage(input));  
                   }
                   isOn = true;                  
                }

            }

            if (messages.Count > 0)
            {
                Console.WriteLine("Total number of messages: {0}", messages.Count);

                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else if(messages.Count == 0)
            {
                Console.WriteLine("No messages sent.");
            }
        }

        public static string EncryptMessage(string message)
        {
            int messageLength = message.Length;

            char[] reversedMessage = Reverse(message);

            for (int i = 0; i < messageLength; i++)
            {
                if (((int)reversedMessage[i] >= 65) && ((int)reversedMessage[i] <= 77))
                {
                    reversedMessage[i] = Convert.ToChar((int)reversedMessage[i] + 13);
                }
                else if (((int)reversedMessage[i] >= 78) && ((int)reversedMessage[i] <= 90))
                {
		            reversedMessage[i] = Convert.ToChar((int)reversedMessage[i] - 13);
                }
                else if (((int)reversedMessage[i] >= 97) && ((int)reversedMessage[i] <= 109))
                {
                    reversedMessage[i] = Convert.ToChar((int)reversedMessage[i] + 13);
                }
                else if (((int)reversedMessage[i] >= 110) && ((int)reversedMessage[i] <= 122))
                {
		            reversedMessage[i] = Convert.ToChar((int)reversedMessage[i] - 13);
                }
                else if (reversedMessage[i] == ' ' || reversedMessage[i] == ',' || reversedMessage[i] == '.' || reversedMessage[i] == '!' || reversedMessage[i] == '?' )
                {
		            reversedMessage[i] = EncryptSymbol(reversedMessage[i]);
                }
                else
	            {
                    reversedMessage[i] = reversedMessage[i]; 
	            }
            }


            return new string(reversedMessage);
        }

        public static char EncryptSymbol(char symbol)
        {
            char encryptedSymbol;

            switch (symbol)
            {
                case ' ':
                    encryptedSymbol = '+';
                    break;
                case ',':
                    encryptedSymbol = '%';
                    break;
                case '.':
                    encryptedSymbol = '&';
                    break;
                case '?':
                    encryptedSymbol = '#';
                    break;
                case '!':
                    encryptedSymbol = '$';
                    break;
                default: encryptedSymbol = '-';
                    break;
            }
            return encryptedSymbol;
        }

        public static char[] Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return charArray;
        }
    }
}
