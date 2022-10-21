using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            input.Reverse();

            Predicate<int> isEven = number => number % n != 0;

            input = input.FindAll(isEven);

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
