using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                for (int r = 0; r <= counter; r++)
                {
                    Console.Write($"{i} ");
                }
                counter++;
                Console.WriteLine("");
            }
        }
    }
}
