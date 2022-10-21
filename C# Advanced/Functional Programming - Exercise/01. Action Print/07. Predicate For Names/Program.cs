using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main()
        {
            int arg = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            int lenght = names.Count;

            Predicate<string> predicate = name => name.Length <= arg;

            names = names.FindAll(predicate);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
