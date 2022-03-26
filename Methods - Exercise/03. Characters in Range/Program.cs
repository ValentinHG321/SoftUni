using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main() => CharInRange();

        static void CharInRange()
        {
            char startInput = char.Parse(Console.ReadLine());
            char endInput = char.Parse(Console.ReadLine());
            char firstSwapSec;
            char secondSwapFirst;
            if (startInput > endInput)
            {
                firstSwapSec = endInput;
                secondSwapFirst = startInput;
                startInput = firstSwapSec;
                endInput = secondSwapFirst;
            }
            for (int i = startInput; i < endInput - 1; i++)
            {
                startInput++;
                Console.Write($"{startInput} ");
            }
        }
    }
}
