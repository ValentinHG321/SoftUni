using System;
using System.Linq;

namespace _00.DemoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Select(x => x + 2).ToArray();

            int[] second = input.Select(x => x + 2).ToArray();
            Console.WriteLine(string.Join("-" , input.Select(x => x + 2)));
            Console.WriteLine(string.Join("|", input));
        }
    }
}
