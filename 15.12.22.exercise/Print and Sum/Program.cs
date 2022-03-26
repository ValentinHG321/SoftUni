using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <= stop; i++)
            {
                Console.Write($"{i} ");
                count += i;
            }
            Console.WriteLine($"\nSum: {count}");
        }
    }
}
