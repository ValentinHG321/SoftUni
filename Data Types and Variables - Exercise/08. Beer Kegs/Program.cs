using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double calc = 0;
            string keg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string keg2 = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double Pi = Math.PI;

                double calc2 = Pi * (radius * radius) * height;
                if (calc < calc2)
                {
                    calc = calc2;
                    keg = keg2;
                }
            }
            Console.WriteLine(keg);
        }
    }
}
