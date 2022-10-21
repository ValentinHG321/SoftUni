namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string line = reader.ReadLine();
                string sum = string.Empty;
                while (line != null)
                {

                    if (counter % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        sum += line;
                        sum += Environment.NewLine;
                    }

                    line = reader.ReadLine();
                    counter++;
                }
                return sum;
            }
        }

        private static string Replace(string line)
        {
            return line.Replace('-', '@')
                       .Replace(',', '@')
                       .Replace('.', '@')
                       .Replace('!', '@')
                       .Replace('?', '@');
        }

        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }
    }
}
