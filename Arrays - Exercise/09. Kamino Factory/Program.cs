//using System;
//using System.Linq;

//namespace _09._Kamino_Factory
//{
//    class Program
//    {
//        static void Main()
//        {
//            int sequenceLenght = int.Parse(Console.ReadLine());
//            string input;
//            int SeqStartInx = 0;
//            int SeqStartInxPrev = 0;
//            int count = 0;
//            int maxSequence = 0;
//            int[] outputDNA = new int[sequenceLenght];

//            while ((input = Console.ReadLine()) != "Clone them!")
//            {
//                int[] DNAseq = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

//                int previousSum = 0;
//                int sum = 1;
//                for (int i = 0; i < DNAseq.Length - 1; i++)
//                {

//                    if (DNAseq[i] == DNAseq[i + 1])
//                    {

//                        if ((count++) > maxSequence)
//                        {
//                            SeqStartInx = i - count;
//                            maxSequence = count;

//                            for (int j = 0; j < outputDNA.Length; j++)
//                            {
//                                sum += DNAseq[j];
//                            }

//                            if (SeqStartInx < SeqStartInxPrev)
//                            {

//                                if (sum > previousSum)
//                                {
//                                    outputDNA = DNAseq;
//                                }

//                            }

//                            else
//                            {
//                                previousSum = sum;
//                                SeqStartInxPrev = SeqStartInx;
//                            }

//                        }

//                    }

//                    else
//                    {
//                        count = 0;
//                    }

//                }



//                //Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
//                //Console.WriteLine(String.Join(' ', DNA));
//            }
//            Console.WriteLine(string.Join(' ', outputDNA));
//        }
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.ReadLine();
//        string[] bestDna = null;
//        int bestLen = -1;
//        int startIndex = -1;
//        int bestDnaSum = 0;
//        int bestSampleIndex = 0;

//        int currentSampleIndex = 0;

//        while (true)
//        {
//            string input = Console.ReadLine();

//            if (input == "Clone them!")
//            {
//                break;
//            }

//            string[] currentDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
//            int currentLen = 0;
//            int currentBestLen = 0;
//            int currentEndIndex = 0;

//            for (int i = 0; i < currentDna.Length; i++)
//            {
//                if (currentDna[i] == "1")
//                {
//                    currentLen++;
//                    if (currentLen > currentBestLen)
//                    {
//                        currentEndIndex = i;
//                        currentBestLen = currentLen;
//                    }
//                }
//                else
//                {
//                    currentLen = 0;
//                }
//            }

//            int currentStartIndex = currentEndIndex - currentBestLen + 1;

//            bool isCurrentDnaBetter = false;
//            int currentDnaSum = currentDna.Select(int.Parse).Sum();

//            if (currentBestLen > bestLen)
//            {
//                isCurrentDnaBetter = true;
//            }
//            else if (currentBestLen == bestLen)
//            {
//                if (currentStartIndex < startIndex)
//                {
//                    isCurrentDnaBetter = true;
//                }
//                else if (currentStartIndex == startIndex)
//                {
//                    if (currentDnaSum > bestDnaSum)
//                    {
//                        isCurrentDnaBetter = true;
//                    }
//                }
//            }

//            currentSampleIndex++;

//            if (isCurrentDnaBetter)
//            {
//                bestDna = currentDna;

//                bestLen = currentBestLen;

//                startIndex = currentStartIndex;

//                bestDnaSum = currentDnaSum;

//                bestSampleIndex = currentSampleIndex;
//            }
//        }

//        Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
//        Console.WriteLine(string.Join(' ', bestDna));
//    }
//}
using System;
using System.Linq;

namespace _02_SecondExercise
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] best = new int[length];
            int bestLength = int.MinValue,
                bestIndex = int.MinValue,
                bestSum = int.MinValue,
                bestStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestIndex = currentIndex;
                    bestSum = data.Sum();
                    best = data;
                    bestStart = index;
                }
                else if (currentLength == bestLength)
                {
                    if (currentIndex < bestIndex)
                    {
                        bestLength = currentLength;
                        bestIndex = currentIndex;
                        bestSum = data.Sum();
                        best = data;
                        bestStart = index;
                    }
                    else if (currentIndex == bestIndex)
                    {
                        if (data.Sum() > bestSum)
                        {
                            bestLength = currentLength;
                            bestIndex = currentIndex;
                            bestSum = data.Sum();
                            best = data;
                            bestStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {bestStart} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", best));
        }
    }
}