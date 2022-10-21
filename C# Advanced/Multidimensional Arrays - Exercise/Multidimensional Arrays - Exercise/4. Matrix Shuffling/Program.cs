using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int totalRows = array[0];
            int totalCols = array[1];
                        
            string[,] matrix = new string[totalRows, totalCols];

            FillMatrix(matrix);

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (ValidateCommand(command, totalRows, totalCols))
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    string firstElement = matrix[row1,col1];
                    string secondElement = matrix[row2,col2];
                    
                    matrix[row2, col2] = firstElement;
                    matrix[row1, col1] = secondElement;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine(); 
            }
        }

        private static bool ValidateCommand(string[] command , int totalRows, int totalCols)
        {
            if (command[0] == "swap" && command.Count() == 5)
            {
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                if (   row1 >= 0 && row1 < totalRows 
                    && col1 >= 0 && col1 < totalCols 
                    && row2 >= 0 && row2 < totalRows
                    && col2 >= 0 && col2 < totalCols)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
