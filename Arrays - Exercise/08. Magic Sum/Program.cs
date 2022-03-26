using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main( )
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int givenNum = int.Parse(Console.ReadLine());

            for (int scanAllNum = 0; scanAllNum < inputArr.Length; scanAllNum++)
            {
                int holdNum = inputArr[scanAllNum];

                for (int check = scanAllNum + 1; check < inputArr.Length; check++)
                {
                    if (givenNum == holdNum + inputArr[check])
                    {
                        Console.WriteLine($"{holdNum} {inputArr[check]}");
                    }
                }
            }
        }
    }
}
