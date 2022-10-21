using System;
using System.Linq;

namespace _01_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            SmallestNum();
        }

        static void SmallestNum()
        {
            int[] all = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                all[i] = input;
            }
            Console.WriteLine(all.Min());
        }
    }
}
