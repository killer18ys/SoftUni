using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_RadioactiveMutantVampireBunnies
{
    class RadioactiveMutantVampireBunnies
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];

            char[,] matrix = new char[rows, cols];
            int playerCurrRow = 0;
            int playerCurrCol = 0; 

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                    if(line[col] == 'P')
                    {
                        playerCurrRow = row;
                        playerCurrCol = col;
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                matrix = bunnyJump(matrix);

                int playerPrevRow = playerCurrRow;
                int playerPrevCol = playerCurrCol;

                switch (commands[i])
	            {
		            case 'U':
                        playerCurrRow -= 1;
                        break;
                    case 'D':
                        playerCurrRow += 1;
                        break;
                    case 'L':
                        playerCurrCol -= 1;
                        break;
                    case 'R':
                        playerCurrCol += 1;
                        break;
                    default:
                        Console.WriteLine("Wrong Commad");
                        break;
	            }

                if (playerCurrRow >= 0 && playerCurrRow < rows && playerCurrCol >= 0 && playerCurrCol < cols)
                {
                    if (matrix[playerCurrRow, playerCurrCol] != 'B')
                    {
                        matrix[playerCurrRow, playerCurrCol] = 'P';
                        matrix[playerPrevRow, playerPrevCol] = '.';
                    }
                    else
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("dead: {0} {1}", playerCurrRow, playerCurrCol);
                        break;
                    }   
                }
                else
                {
                    if (playerCurrRow >= rows)
                    {
                        playerCurrRow = rows - 1;
                    }

                    if (playerCurrRow < 0)
                    {
                        playerCurrRow = 0;
                    }

                    if (playerCurrCol >= cols)
                    {
                        playerCurrCol = cols - 1;
                    }

                    if (playerCurrCol < 0)
                    {
                        playerCurrCol = 0;
                    }

                    matrix[playerPrevRow, playerPrevCol] = '.';

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("won: {0} {1}", playerCurrRow, playerCurrCol);
                    break;
                }


            } 
        }


        static char[,] bunnyJump(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            char[,] matrixCopy = (char[,])matrix.Clone();

            for (int row = 0; row < rows ; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrixCopy[row, col].Equals('B'))
                    {
                        if (row + 1 < rows)
                        {
                            matrix[row + 1, col] = 'B'; 
                        }
                        
                        if (row - 1 >= 0)
                        {
                            matrix[row - 1, col] = 'B';
                        }

                        if (col - 1 >= 0)
                        {
                            matrix[row, col - 1] = 'B';
                        }

                        if (col + 1 < cols)
                        {
                            matrix[row, col + 1] = 'B';
                        }
                    }

                }
            }

            return matrix;
        }

    }
}
