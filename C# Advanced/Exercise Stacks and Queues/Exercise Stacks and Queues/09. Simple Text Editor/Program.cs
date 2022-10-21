using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> UndoStack = new Stack<string>();

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("1"))
                {
                    UndoStack.Push(sb.ToString());
                    string textforAdd = command.Split()[1];
                    sb.Append(textforAdd);
                }
                else if (command.StartsWith("2"))
                {
                    UndoStack.Push(sb.ToString());
                    int count = int.Parse(command.Split()[1]);
                    sb.Remove(sb.Length - count , count);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split()[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else if (command.StartsWith("4"))
                {
                    sb = new StringBuilder(UndoStack.Pop());
                }

            }
        }
    }
}
