using System;

namespace _01_RandomizeWords

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)

            {
                int rndIdx = rnd.Next(words.Length);

                string currentWord = words[i];
                words[i] = words[rndIdx];
                words[rndIdx] = currentWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }      

        }
    }
}
