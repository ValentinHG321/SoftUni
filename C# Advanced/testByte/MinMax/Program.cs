using System;
using System.Linq;

namespace MinMax
{
    internal class Program
    {
        static void Main()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in input)
            {
                if (item >= max)
                {
                    max = item;
                }
                if (item <= min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"min:{min} - max:{max}");
        }
    }
}
