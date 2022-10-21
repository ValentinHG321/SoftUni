using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < count; i++)
            {
                char chars = char.Parse(Console.ReadLine());
                int sum = chars;
                totalSum += sum;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
