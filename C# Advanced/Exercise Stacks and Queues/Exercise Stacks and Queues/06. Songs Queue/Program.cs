using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main()
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> songsInQueue = new Queue<string>(songs);

            while (songsInQueue.Count > 0)
            {
                string input = Console.ReadLine();
                string command = input.Substring(0, 4).Trim();
                string song = input.Substring(4);
                
                switch (command)
                {
                    case "Play":
                        songsInQueue.Dequeue();
                        break;
                    case "Add":
                        if (!songsInQueue.Contains(song))
                        {
                            songsInQueue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songsInQueue));
                        break;

                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
