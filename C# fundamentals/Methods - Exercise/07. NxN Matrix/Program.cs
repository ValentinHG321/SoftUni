using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            NxNMatrix(input); 
        }

        static void NxNMatrix(int input)
        {
            int[] xMatrix = new int[input];
            for (int y = 0; y < xMatrix.Length; y++)
            {
                for (int x = 0; x < xMatrix.Length; x++)
                {
                    xMatrix[x] = input;
                }
                Console.WriteLine(string.Join(' ', xMatrix));
            }          
        }
    }
}
