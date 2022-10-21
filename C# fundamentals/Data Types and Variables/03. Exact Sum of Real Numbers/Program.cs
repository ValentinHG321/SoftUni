using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                decimal total = 0;
                for (int i = 0; i < n; i++)
                {
                    decimal n1 = decimal.Parse(Console.ReadLine());
                    total += n1;
                }
                Console.WriteLine($"{total}");
            }
        }
    }
}
