using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] items = new double[rawInput.Length];
            for (int i = 0; i < rawInput.Length; i++)
            {
                items[i] = double.Parse(rawInput[i]);
            }
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == -0)
                {
                    Console.WriteLine("0 => 0");
                }
                else if (items[i] == -0.0)
                {
                    Console.WriteLine("0.0 => 0");
                }
                else if (items[i] == -0.00)
                {
                    Console.WriteLine("0.00 => 0");
                }
                else
                {
                    Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
                }
            }
        }
    }
}
