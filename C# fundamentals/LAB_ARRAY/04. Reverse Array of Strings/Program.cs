using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Reverse = Console.ReadLine().Split();
            for (int i = Reverse.Length - 1; i >= 0; i--)
            {
                Console.Write(Reverse[i] + " ");
            }
        }
    }
}