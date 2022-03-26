using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main( )
        {
            int linesNums = int.Parse(Console.ReadLine());
            int[] firstArray = new int[linesNums];
            int[] secondArray = new int[linesNums];
            for (int i = 0; i < linesNums; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    secondArray[i] = numbers[1];
                    firstArray[i] = numbers[0];
                }
                else
                {
                    secondArray[i] = numbers[0];
                    firstArray[i] = numbers[1];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
