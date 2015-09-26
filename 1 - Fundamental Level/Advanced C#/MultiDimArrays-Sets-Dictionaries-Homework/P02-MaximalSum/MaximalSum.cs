using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string inputFirstLine = Console.ReadLine();


            int n = int.Parse(inputFirstLine.Split(' ')[0]);

            int m = int.Parse(inputFirstLine.Split(' ')[1]);

            int[,] matrix = new int[n, m];
            int[,] maxSumMatrix = new int[3, 3];

            int maxSum = 0;
            int tempSum = 0;

            string[] input;


            for (int row = 0; row < n; row++)
            {
                input = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {

                    tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                               matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                               matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;

                        for (int rowInner = 0; rowInner < maxSumMatrix.GetLength(0); rowInner++)
                        {
                            for (int colInner = 0; colInner < maxSumMatrix.GetLength(1); colInner++)
                            {
                                maxSumMatrix[rowInner, colInner] = matrix[row + rowInner, col + colInner];
                            }
                        }
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("Max sum {0}", maxSum);
            for (int row = 0; row < maxSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxSumMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", maxSumMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
