using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            if (i <= 10)
            {
                while (i <= 10)
                {
                    Console.WriteLine($"{x} X {i} = {x * i}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine($"{x} X {i} = {x * i}");
            }
        }
    }
}
