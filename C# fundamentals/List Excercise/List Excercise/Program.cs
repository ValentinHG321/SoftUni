using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine()
                .Split(" " , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int passangers = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(input[0] == "end")
                {
                    break;
                }

                if(input[0] == "Add")
                {
                    wagon.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        int calc = wagon[i] + int.Parse(input[0]);
                        if (calc <= passangers)
                        {
                            wagon[i] = calc;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(String.Join(" ", wagon));
        }
    }
}
