using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int,int> numbersD = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersD.ContainsKey(number))
                {
                    numbersD.Add(number, 1);
                }
                else
                {
                    numbersD[number]++;
                }
            }
            Console.WriteLine(numbersD.First(entry => entry.Value % 2 == 0).Key);
        }
    }
}
