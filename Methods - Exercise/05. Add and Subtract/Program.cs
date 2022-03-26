using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(AddNSubtrackt(first, second, third)); 
        }
        static int AddNSubtrackt(int first , int second , int third)
        {
            return first + second - third;
        }
    }
}
