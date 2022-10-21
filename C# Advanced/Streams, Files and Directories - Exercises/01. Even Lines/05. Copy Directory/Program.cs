﻿namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath);
            }
            Directory.CreateDirectory(outputPath);
            string[] filesArr = Directory.GetFiles(inputPath);

            foreach (var file in filesArr)
            {
                var filename = Path.GetFileName(file);
                var copyDestination = Path.Combine(outputPath, filename);
                File.Copy(file, copyDestination);
            }
        }
    }
}
