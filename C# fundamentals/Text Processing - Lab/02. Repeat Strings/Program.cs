using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main()
        {
            string[] allWords = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string result = string.Empty;

            foreach (string word in allWords)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result); 
        }
    }
}
