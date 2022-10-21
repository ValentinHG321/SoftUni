using System;
using System.Linq;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> print = name => Console.WriteLine(name);

            foreach (var name in input)
            {
                print(name);
            }

        }
    }
}
