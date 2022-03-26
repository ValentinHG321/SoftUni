using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(input));
        }

        static string MiddleCharacter(string input)
        {
            int lenght = input.Length;
            int midStart = lenght / 2;
            int plusNum = 0;
            string output = string.Empty;

            if (lenght % 2 == 0)
            {
                plusNum = 1;
                midStart -= 1;
            }

            else if (lenght % 2 != 0)
            {
                plusNum = 0;
            }

            for (int i = midStart; i <= midStart + plusNum; i++)
            {
                output += input[i];
            }

            return output;
        }
    }
}
