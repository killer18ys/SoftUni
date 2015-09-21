using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            List<int> tempSeq = new List<int>();
            Queue<string> sequencesQueue = new Queue<string>();


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    tempSeq.Add(numbers[i]);

                    if (i == numbers.Length - 2)
                    {
                      tempSeq.Add(numbers[i + 1]);
                      sequencesQueue.Enqueue(string.Join(" ", tempSeq));
                      tempSeq.Clear();
                    }
                }
                else
                {
                    tempSeq.Add(numbers[i]);
                    sequencesQueue.Enqueue(string.Join(" ", tempSeq));
                    tempSeq.Clear();
                }
            }

            int seqMaxCount = int.MinValue;

            foreach (string sequence in sequencesQueue)
            {
                if (sequence.Split(' ').Length > seqMaxCount )
                {
                    seqMaxCount = sequence.Split(' ').Length;
                }
            }


            int sequencesCount = sequencesQueue.Count;
            string longestSeq = "";

            for (int i = 0; i < sequencesCount; i++)
			{

                if (sequencesQueue.Peek().Split(' ').Length == seqMaxCount)
                {
                    longestSeq = sequencesQueue.Dequeue().ToString();
                    Console.WriteLine(longestSeq);
                }
                else
                {
                    Console.WriteLine(sequencesQueue.Dequeue());
                }
			}


           Console.WriteLine("Longest: {0}", longestSeq);
           


        }
    }
}
