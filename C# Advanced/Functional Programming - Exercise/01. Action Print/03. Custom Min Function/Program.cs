using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[],int> lowestNum = num => num.Min();


            Console.WriteLine(lowestNum(input));
        }
    }
}
