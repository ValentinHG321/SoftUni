using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                int num = int.Parse(Input[i]);
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
