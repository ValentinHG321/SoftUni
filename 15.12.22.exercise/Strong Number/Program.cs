using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string _in = Console.ReadLine();
            long Sum = 0;

            for (int i = 0; i < _in.Length; i++)
            {
                char c = _in[i];
                int cd = (int)c - 48;

                long x = 1;
                for (int r = cd; r > 1; r--)
                {
                    x *= r;
                }
                Sum += x;
            }
            if (Sum == int.Parse(_in))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
