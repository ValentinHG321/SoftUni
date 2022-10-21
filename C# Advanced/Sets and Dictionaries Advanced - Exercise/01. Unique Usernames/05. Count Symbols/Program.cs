using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char , int> reapetedChars = new SortedDictionary<char, int>();

            foreach (char ch in input)
            {
                if (!reapetedChars.ContainsKey(ch))
                {
                    reapetedChars.Add(ch, 1);
                }
                else
                {
                    reapetedChars[ch]++;
                }
            }
            foreach (KeyValuePair<char, int> ch in reapetedChars)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
