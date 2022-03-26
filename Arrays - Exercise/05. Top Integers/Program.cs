using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main( )
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topInt = new int[inputArray.Length];
            int topIntIdx = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentNum = inputArray[i];
                bool isTopInt = true;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int nextNum = inputArray[j];

                    if (currentNum <= nextNum)
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    topInt[topIntIdx] = currentNum;
                    topIntIdx++;
                }
            }
            for (int i = 0; i < topIntIdx; i++)
            {
             Console.Write($"{topInt[i]} ");
            }
        }
    }
}
