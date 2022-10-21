using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main()
        {
            SortedSet<string> sortedElements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elementInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string element in elementInput)
                {
                    sortedElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ',sortedElements));
        }
    }
}
