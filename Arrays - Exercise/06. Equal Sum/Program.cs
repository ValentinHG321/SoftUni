using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main( )
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool notEqual = true;
            for (int midNum = 0; midNum < inputArr.Length; midNum++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int leftRot = midNum; 1 <= leftRot; leftRot--)
                {
                    leftSum += inputArr[leftRot - 1];
                }
                for (int rightRot = midNum; rightRot < inputArr.Length - 1; rightRot++)
                {
                    rightSum += inputArr[rightRot + 1];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(midNum);
                    notEqual = false;
                    break;
                }

            }
            if (notEqual)
            {
                Console.WriteLine("no");
            }

        }
    }
}
