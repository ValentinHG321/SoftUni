using System;

namespace Csharp_Lekciq_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = 1; i <= n*2; i++)
            {
                if (i % 2 != 0)
                {
                    x+=i;
                    Console.WriteLine(i);
                }   
            }
            Console.WriteLine($"Sum: {x}");
        }
    }
}
