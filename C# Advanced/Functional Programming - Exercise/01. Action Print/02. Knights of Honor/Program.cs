using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> print = name => Console.WriteLine("Sir " + name);

            foreach (var name in input)
            {
                print(name);
            }

        }
    }
}
