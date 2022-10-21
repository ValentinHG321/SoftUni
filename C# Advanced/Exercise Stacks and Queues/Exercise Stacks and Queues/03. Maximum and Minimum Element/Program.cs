﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;

                    case 2:
                        stack.Pop();
                        break;

                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
