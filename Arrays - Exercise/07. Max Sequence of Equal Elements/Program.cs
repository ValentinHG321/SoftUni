using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            int maxSeqStartInx = 0;
            int count = 0;
            int maxSequence = 0;
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                if (inputArr[i] == inputArr[i + 1])
                {
                    count++;
                    if (count > maxSequence)
                    {
                        maxSeqStartInx = i - count;
                        maxSequence = count;
                    }

                }
                else
                {
                    count = 0;
                }
            }
            for (int i = maxSeqStartInx + 1; i <= maxSeqStartInx + maxSequence + 1; i++)
            {
                Console.Write(inputArr[i] + " ");
            }
            
        }
    }
}

