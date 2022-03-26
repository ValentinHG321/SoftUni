using System;
using System.Collections.Generic;

namespace _01_Reverse_Strings
{
    internal class Program
    {
        static void Main()
        {

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end") { break; }

                List<char> reverse = new List<char>();

                for (int i = 0; i < line.Length; i++)
                {
                    reverse.Add(line[i]);
                }

                reverse.Reverse();

                string reversedString = new string(reverse.ToArray());

                Console.WriteLine($"{line} = {reversedString}");
            }
        }
    }
}
