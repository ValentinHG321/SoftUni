using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] switchArray = new string[array.Length];
            int z = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                switchArray[z] = array[i];
                z++;
            }

            string new2 = string.Join(' ', switchArray);

            int[] output = new2.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(' ', output));
        }
    }
}
