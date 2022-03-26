using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(token[1]);
                        input.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(token[1]);
                        input.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(token[1]);
                        input.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(token[1]);
                        int InxToInsert = int.Parse(token[2]);
                        input.Insert(InxToInsert, numToInsert);
                        break;
                }
                
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
