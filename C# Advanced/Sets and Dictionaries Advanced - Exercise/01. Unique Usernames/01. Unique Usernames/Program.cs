using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine , uniqueNames));
        }
    }
}
