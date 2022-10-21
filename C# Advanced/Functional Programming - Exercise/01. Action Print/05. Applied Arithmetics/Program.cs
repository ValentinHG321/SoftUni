using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>,List<int>> add = list => list.Select(num => num += 1).ToList();
            Func<List<int>,List<int>> multi = list => list.Select(num => num *= 2).ToList();
            Func<List<int>,List<int>> sub = list => list.Select(num => num -= 1).ToList();
            Action<List<int>> print = list => Console.WriteLine(string.Join(" " , list));

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                switch (input)
                {
                    case "add":
                        numbers = add(numbers);
                        break;

                    case "multiply":
                        numbers = multi(numbers);
                        break;

                    case "subtract":
                        numbers = sub(numbers);
                        break;

                    case "print":
                       print(numbers);
                        break;
                }
            }
        }
    }
}
