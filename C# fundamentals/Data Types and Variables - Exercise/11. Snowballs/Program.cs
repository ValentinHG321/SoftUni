using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsN = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            int snowballSnowH = 0;
            int snowballTimeH = 0;
            int snowballQualityH = 0;
            for (int i = 0; i < snowballsN; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int divide = snowballSnow / snowballTime;
                int up = divide;
                for (int j = 1; j < snowballQuality; j++)
                {
                    divide *= up;
                }

                if (snowballValue < divide)
                {
                    snowballValue = divide;
                    snowballSnowH = snowballSnow;
                    snowballTimeH = snowballTime;
                    snowballQualityH = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowH} : {snowballTimeH} = {snowballValue} ({snowballQualityH})");
        }
    }
}
