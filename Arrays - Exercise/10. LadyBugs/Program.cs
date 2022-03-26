using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main( )
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsInx = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladyBugsInx.Contains(index))
                {
                    field[index] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int initialInx = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (initialInx < 0 || initialInx >= field.Length)
                {
                    continue;
                }

                if (field[initialInx]==0)
                {
                    continue;
                }
                field[initialInx] = 0;
                int nextInx = initialInx;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextInx += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextInx -= flyLength;
                    }

                    if (nextInx < 0 || nextInx >= field.Length)
                    {
                        break;
                    }
                    if (field[nextInx] == 0)
                    {
                        break;
                    }
                }
                if (nextInx >= 0 && nextInx < field.Length)
                {
                    field[nextInx] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
