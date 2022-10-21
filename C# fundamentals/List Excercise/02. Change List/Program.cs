using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            while (true)
            {

                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if (command[0] == "end")

                {
                    break;
                }
                int num = int.Parse(command[1]);

                switch (command[0])
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == num);
                        break;

                    case "Insert":
                        int num2 = int.Parse(command[2]);
                        numbers.Insert(num2, num);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
