using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, long> table = new Dictionary<string, long>();

            string resource = string.Empty;

            while (true) 
            {
                resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                long quantity = long.Parse(Console.ReadLine());

                //if (table.ContainsKey(resource))
                //{
                //    table[resource] += quantity;
                //}
                //else
                //{
                //    table.Add(resource, quantity);
                //}

                if (!table.ContainsKey(resource))
                {
                    table[resource] = 0;
                }

                table[resource] += quantity;
            }

            foreach (var item in table)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
