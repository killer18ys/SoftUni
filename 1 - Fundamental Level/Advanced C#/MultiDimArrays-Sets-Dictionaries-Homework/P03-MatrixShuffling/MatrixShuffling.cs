using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] intMatrix = new int[n, m];
            string[,] stringMatrix = new string[n, m];

            string input;
            int result;
            bool isInt = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    input = Console.ReadLine();

                    if (int.TryParse(input, out result))
                    {
                        intMatrix[row, col] = result;
                        isInt = true;
                    }
                    else
                    {
                        stringMatrix[row, col] = input;
                    }
                }
            }

            Console.WriteLine();
            
            string pattern = @"swap(\s\d){4}";
            Regex reg = new Regex(pattern);

            int row1, col1, row2, col2, tempInt;
            string tempString;

            do
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (reg.IsMatch(input))
                {
                    row1 = int.Parse(input.Split(' ')[1]);
                    col1 = int.Parse(input.Split(' ')[2]);
                    row2 = int.Parse(input.Split(' ')[3]);
                    col2 = int.Parse(input.Split(' ')[4]);

                    if (isInt)
                    {
                        tempInt = intMatrix[row1, col1];
                        intMatrix[row1, col1] = intMatrix[row2, col2];
                        intMatrix[row2, col2] = tempInt;

                        PrintMatrix(intMatrix);
                    }
                    else
                    {
                        tempString = stringMatrix[row1, col1];
                        stringMatrix[row1, col1] = stringMatrix[row2, col2];
                        stringMatrix[row2, col2] = tempString;

                        PrintMatrix(stringMatrix);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            } while (input != "END");

        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ",matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
