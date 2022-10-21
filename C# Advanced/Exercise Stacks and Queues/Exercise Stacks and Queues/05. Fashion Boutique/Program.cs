using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            int rackCapacity = int.Parse(Console.ReadLine());

            int totalRacks = 0;

            int sum = 0;
            int sumFuture = 0;
            int stackCount = stack.Count;

            for (int i = 1; i <= stackCount; i++)
            {
                sum += stack.Peek();

                if (stack.Count > 1)
                {
                    sumFuture = sum + stack.ElementAt(1);
                }
                  
                if (sumFuture <= rackCapacity)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Pop();
                    sum = 0;
                    totalRacks++;
                }

            
            }

            if (sum > 0)
            {
                totalRacks++;
            }
            Console.WriteLine(totalRacks);
        }
    }
}
