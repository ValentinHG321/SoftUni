using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            double spice = double.Parse(Console.ReadLine());
            double days = 0;
            double calc = 0;
            while (spice >= 100)
            {
                days++;
                calc += spice - 26;
                spice -= 10;
            }
            if (calc >= 26)
            {
                calc -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(calc);
        }
    }
}
