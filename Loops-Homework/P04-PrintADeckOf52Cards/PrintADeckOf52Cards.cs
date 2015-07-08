using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 14; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    PrintCard(i, k);
                }
                Console.WriteLine();
            }


        }

        static void PrintCard(int card, int suit)
        {
            string tempCard;
            char tempSuit;

            switch (card)
            {
                case 2:
                    tempCard = "2";
                    break;
                case 3:
                    tempCard = "3";
                    break;
                case 4:
                    tempCard = "4";
                    break;
                case 5:
                    tempCard = "5";
                    break;
                case 6:
                    tempCard = "6";
                    break;
                case 7:
                    tempCard = "7";
                    break;
                case 8:
                    tempCard = "8";
                    break;
                case 9:
                    tempCard = "9";
                    break;
                case 10:
                    tempCard = "10";
                    break;
                case 11:
                    tempCard = "J";
                    break;
                case 12:
                    tempCard = "Q";
                    break;
                case 13:
                    tempCard = "K";
                    break;
                case 14:
                    tempCard = "A";
                    break;
                default:
                    tempCard = "Not a Card";
                    break;
            }

            switch (suit)
            {
                case 1:
                    tempSuit = '\u2666';
                    break;
                case 2:
                    tempSuit = '\u2663';
                    break;
                case 3:
                    tempSuit = '\u2660';
                    break;
                case 4:
                    tempSuit = '\u2665';
                    break;
                default:
                    tempSuit = ' ';
                    break;
            }

            Console.Write("{0,3}{1}", tempCard, tempSuit);
        }
    }
}
