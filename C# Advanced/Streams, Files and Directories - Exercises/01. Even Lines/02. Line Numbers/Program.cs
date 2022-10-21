namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] linesFromFile = File.ReadAllLines(inputFilePath);
            int count = 0;
            List<string> outputLines = new List<string>();

            foreach (string line in linesFromFile)
            {
                count++;

                int countLetters = line.Count(char.IsLetter);
                int countSymbol = line.Count(char.IsPunctuation);

                string modifiedLine = $"Line {count}: {line} ({countLetters})({countSymbol})";
                outputLines.Add(modifiedLine);
            }
            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}


