using System;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meter = decimal.Parse(Console.ReadLine());
            decimal km = meter / 1000;
            Console.WriteLine($"{km:F2}");
        }
    }
}
