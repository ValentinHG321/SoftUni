using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExam_03._Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                List<string> secondInputs = Console.ReadLine().Split(", ").ToList();

                string command = secondInputs[0];

                switch (command)
                {
                    case "Add":
                        if (input.Contains(secondInputs[1]))
                        {
                            Console.WriteLine("Card is already in the deck");
                            continue;
                        }
                        else
                        {
                            input.Add(secondInputs[1]);
                            Console.WriteLine("Card successfully added");
                        }

                        break;

                    case "Remove":
                        if (input.Contains(secondInputs[1]))
                        {
                            input.Remove(secondInputs[1]);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                            continue;
                        }
                        break;

                    case "Remove At":
                        int index = int.Parse(secondInputs[1]);
                        if (index < 0 || index > input.Count)
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                        else
                        {
                            input.RemoveAt(index);
                            Console.WriteLine("Card successfully removed");
                        }

                        break;

                    case "Insert":
                        index = int.Parse(secondInputs[1]);

                        if (index < 0 || index > input.Count)
                        {
                            Console.WriteLine("Index out of range");
                            continue;
                        }
                        else if (input.Contains(secondInputs[1]))
                        {
                            Console.WriteLine("Card is already in the deck");
                            continue;
                        }
                        else
                        {
                            string toInsert = secondInputs[2];
                            input.Insert(index, toInsert);
                            Console.WriteLine("Card successfully added");
                        }

                        break;
                }

            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
