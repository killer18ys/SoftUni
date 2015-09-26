using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrixPatternA = new int[n, n];
            int countA = 1;

            int[,] matrixPatternB = new int[n, n];
            int countB = 1;

            for (int col = 0; col < matrixPatternA.GetLength(1); col++)
            {
                for (int row = 0; row < matrixPatternA.GetLength(0); row++)
                {
                    matrixPatternA[row, col] = countA;
                    countA++;
                }
            }

            for (int col = 0; col < matrixPatternB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrixPatternB.GetLength(0); row++)
                    {
                        matrixPatternB[row, col] = countB;
                        countB++;
                    }
                }
                else
                {
                    for (int row = matrixPatternB.GetLength(0) - 1; 0 <= row ; row--)
                    {
                        matrixPatternB[row, col] = countB;
                        countB++;
                    }
                }

            }


            for (int row = 0; row < matrixPatternA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixPatternA.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixPatternA[row, col]);   
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < matrixPatternB.GetLength(0); row++)
            {
                for (int col = 0; col < matrixPatternB.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixPatternB[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
