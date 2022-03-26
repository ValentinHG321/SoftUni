using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            decimal first =decimal.Parse(Console.ReadLine());
            decimal second =decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialDivision(first, second):F2}");
        }
        static decimal FactorialDivision(decimal first , decimal second)
        {
            decimal firstOut = 1;
            decimal secondOut = 1;

            for (decimal i = first; 1 < i; i--)
            {
                firstOut *= i; 
            }
            for (decimal i = second; 1 < i; i--)
            {
                secondOut *= i;
            }
            return firstOut / secondOut;
        }
    }
}
