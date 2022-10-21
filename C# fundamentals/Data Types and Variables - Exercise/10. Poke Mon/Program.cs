using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int origiN = N;
            int count = 0;
            while (N > M)
            {
                count++;
                N -= M;
                if (N == ((double)origiN/2))
                {
                    if (Y > 0)
                    {
                        N /= Y;
                    }

                }
            }

            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
