using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main()
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                int IndexToRemove = text.IndexOf(wordToRemove);
                text = text.Remove(IndexToRemove, wordToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
