using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());

            char[] letters = {'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X'};

            int count = 0;

            List<int> letterWeightsList = LetterWeight(letters);

            List<int> digitsOne = DigitsWeight("CAaaaaXY");
            List<int> digitsTwo = DigitsWeight("CAabbbXY");
            List<int> digitsThree = DigitsWeight("CAaaabXY");
            List<int> digitsFour = DigitsWeight("CAaabbXY");
            List<int> digitsFive = DigitsWeight("CAababXY");
            List<int> digitsSix = DigitsWeight("CAabbaXY");


            List<int> magicMunbersList = new List<int>();

            for (int i = 0; i < letterWeightsList.Count; i++)
            {
                for (int k = 0; k < digitsOne.Count; k++)
                {
                    if ((40 + digitsOne[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }

                for (int k = 0; k < digitsTwo.Count; k++)
                {
                    if ((40 + digitsTwo[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }

                for (int k = 0; k < digitsThree.Count; k++)
                {
                    if ((40 + digitsThree[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }

                for (int k = 0; k < digitsFour.Count; k++)
                {
                    if ((40 + digitsFour[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }

                for (int k = 0; k < digitsFive.Count; k++)
                {
                    if ((40 + digitsFive[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }

                for (int k = 0; k < digitsSix.Count; k++)
                {
                    if ((40 + digitsSix[k] + letterWeightsList[i]) == magicNum)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static int LetterWeightCalc(char letter)
        {
            int weight = 0;

            switch (letter)
            {
                case 'A':
                    weight += 10;
                    break;
                case 'B':
                    weight += 20;
                    break;
                case 'C':
                    weight += 30;
                    break;
                case 'E':
                    weight += 50;
                    break;
                case 'H':
                    weight += 80;
                    break;
                case 'K':
                    weight += 110;
                    break;
                case 'M':
                    weight += 130;
                    break;
                case 'P':
                    weight += 160;
                    break;
                case 'T':
                    weight += 200;
                    break;
                case 'X':
                    weight += 240;
                    break;
            }
            return weight;
        }

        static List<int> LetterWeight(char[] letters)
        {
            List<int> letterWeights = new List<int>();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    letterWeights.Add(LetterWeightCalc(letters[i]) + LetterWeightCalc(letters[k]));
                }
            }

            return letterWeights;
        }

        static List<int> DigitsWeight(string format)
        {
            List<int> digitsWeight = new List<int>();

            if (format == "CAaaaaXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    digitsWeight.Add(4 * i);
                }
            }
            else if (format == "CAabbbXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i != k)
                        {
                            digitsWeight.Add(i + 3 * k);
                        }
                        
                    }
                }
            }
            else if (format == "CAaaabXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i != k)
                        {
                            digitsWeight.Add(3 * i + k);
                        }
                    }
                }
            }
            else if (format == "CAaabbXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i != k)
                        {
                            digitsWeight.Add(2 * i + 2 * k);
                        } 
                    }
                }
            }
            else if (format == "CAababXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i != k)
                        {
                            digitsWeight.Add(i + k + i + k);
                        }
                    }
                } 
            }
            else if (format == "CAabbaXY")
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i != k)
                        {
                            digitsWeight.Add(i + 2 * k + i);
                        }
                    }
                }
            }
            return digitsWeight;
        }

    }
}
