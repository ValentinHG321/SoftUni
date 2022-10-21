using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int count = i;
                int sum = 0;
                while (count != 0)
                {
                    int digit = count % 10;
                    count = count / 10;
                    sum += digit;
                }
                bool check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, check);
            }

        }
    }
}
