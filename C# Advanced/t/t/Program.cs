using System;
using System.Linq;
using System.IO;
namespace t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write old char (A) , new char (B) and split char (C) for new line in format: A,B,C");

            string[] options = Console.ReadLine().Split(',').ToArray();

            if (options.Length == 3)
            {
                char oldChar = char.Parse(options[0]);

                char newChar = char.Parse(options[1]);

                char replace = char.Parse(options[2]);

                string[] data = Console.ReadLine().Replace(oldChar, newChar).Split(replace, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string fileNameOutput = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\ConvertedLog.txt");

                try
                {
                    StreamWriter sw = new StreamWriter(fileNameOutput);
                    sw.WriteLine(string.Join("\n", data));
                    sw.Close();
                }
                catch (Exception message)
                {
                    throw new ArgumentException(message.Message);
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }    
        }
    }
}
