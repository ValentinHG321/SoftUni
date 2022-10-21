﻿using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxRows = array[0];
            int maxCols = array[1];

            char[,] matrix = new char[maxRows, maxCols];

            string snake = Console.ReadLine();

            int index = 0;

            for (int row = 0; row < maxRows; row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < maxCols; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }

                }
                else
                {
                    for (int col = maxCols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }

}
