using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n,n];
            FillMatrix(numbers);
            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;
            int x = n;

            for (int i = 0; i < n; i++)
            {
                x--;
                sumFirstDiagonal += numbers[i,i];
                sumSecondDiagonal += numbers[i,x];
            }
            int sum = sumFirstDiagonal - sumSecondDiagonal;
            Console.WriteLine(Math.Abs(sum));
        }

        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0) ; row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < numbers.GetLength(1) ; col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
