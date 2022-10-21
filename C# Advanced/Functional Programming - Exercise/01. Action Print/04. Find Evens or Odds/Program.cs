using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main()
        {
            int[] firstInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string secontInput = Console.ReadLine();

            int from = firstInput[0];
            int to = firstInput[1];

            Predicate<int> isEven = null;
            List<int> nums = new List<int>();

            for (int i = from; i <= to; i++)
            {
                nums.Add(i);
            }

            if (secontInput == "even")
            {
                isEven = number => number % 2 == 0;
            }
            else if (secontInput == "odd")
            {
                isEven = number => number % 2 != 0;
            }

            nums = nums.FindAll(isEven);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
