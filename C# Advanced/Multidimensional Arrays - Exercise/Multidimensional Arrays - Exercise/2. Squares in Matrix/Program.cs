using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int totalRows = input[0];
            int totalCols = input[1];
            
            int count = 0;

            string[,] matrix = new string[totalRows, totalCols];

            FillMatrix(matrix);

            for (int row = 0; row < totalRows - 1; row++)
            {
                for (int col = 0; col < totalCols - 1; col++)
                { 
                string first = matrix[row, col];
                string second = matrix[row, col + 1];
                string third = matrix[row + 1, col];
                string fourth = matrix[row + 1, col + 1];

                    string[] check = new string[4];
                    check[0] = first;
                    check[1] = second;
                    check[2] = third;
                    check[3] = fourth;

                    bool areEqual = check.Distinct().Count() == 1;
                    if(areEqual)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);   
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
