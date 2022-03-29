using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, decimal[]> orders = new Dictionary<string, decimal[]>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string item = input[0];

                if (item == "buy")
                {
                    break;
                }

                decimal price = decimal.Parse(input[1]);
                decimal qty = decimal.Parse(input[2]);

                decimal[] info = new decimal[2];
                info[1] = qty;
                info[0] = price;

                if (orders.ContainsKey(item))
                {
                    orders[item][0] = price;
                    orders[item][1] += qty;
                }
                else
                {
                    orders.Add(item, info);
                }
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:F2}");
            }
        }
    }
}
