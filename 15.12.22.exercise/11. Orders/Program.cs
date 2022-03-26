using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < N; i++)
            {
                double capsule =double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capCount = int.Parse(Console.ReadLine());
                double price = days * capsule * capCount;
                total += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
