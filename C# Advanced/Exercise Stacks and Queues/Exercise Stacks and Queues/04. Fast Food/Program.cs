using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main()
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> queues = new Queue<int>(orders);

            Console.WriteLine(orders.Max());

            int orderCount = queues.Count;

            for (int i = 1; i <= orderCount; i++)
            {
                if (totalFood >= queues.Peek())
                {
                    totalFood -= queues.Peek();
                    queues.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queues.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + String.Join(' ', queues));
            }
        }
    }
}
