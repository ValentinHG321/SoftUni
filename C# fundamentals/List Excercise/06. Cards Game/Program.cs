using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> deck2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = 0;
            while (true)
            {


                if (deck1.Count < 1)
                {
                    break;
                }
                if (deck2.Count < 1)
                {
                    break;
                }

                int d1 = deck1[n];
                int d2 = deck2[n];

                if (deck1[n] > deck2[n])
                {
                    deck1.Add(d1);
                    deck1.Add(d2);
                    deck1.Remove(d1);
                    deck2.Remove(d2);
                }
                else if (deck1[n] < deck2[n])
                {
                    deck2.Add(d2);
                    deck2.Add(d1);
                    deck1.Remove(d1);
                    deck2.Remove(d2);
                }
                else
                {
                    deck1.Remove(d1);
                    deck2.Remove(d2);
                }

            }
            int sum1 = deck1.Sum();
            int sum2 = deck2.Sum();
            if (sum1 > sum2)
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }
        }
    }
}
