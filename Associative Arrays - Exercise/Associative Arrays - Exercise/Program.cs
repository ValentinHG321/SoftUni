using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Chars_String

{
    internal class Program
    {
        static void Main()
        {
            Dictionary<char, int> charDT = new Dictionary<char, int>();

            char[] charArr = Console.ReadLine().ToArray();

            foreach (char c in charArr)
            {
                if (charDT.ContainsKey(c))
                {
                    charDT[c]++;
                }
                else
                {
                    if (c != ' ')
                    {
                        charDT.Add(c, 1);
                    }
                }
            }
            foreach (var c in charDT)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
