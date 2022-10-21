using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            TopNumber(input);
        }

        static void TopNumber(int input)
        {
            
            for (int i = 1; i < input; i++)
            {
                int cycle = i;
                int sumDigits = 0;
                int digit = 0;
                bool isODD = false;

                while (cycle > 0)
                {

                    digit = cycle % 10;
                    cycle = cycle / 10;
                    sumDigits += digit;
                    if (digit % 2 != 0)
                    {
                        isODD = true;
                    }
                }
                if (sumDigits % 8 == 0)
                {
                    if (!isODD)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                
            }

        }
    }
}
