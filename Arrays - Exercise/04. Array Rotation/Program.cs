using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main( )
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int rotationRedu = rotations % array.Length;

            for (int i = 0; i < rotationRedu; i++)
            {
                string first = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {

                    array[j] = array[j + 1];

                }
                array[^1] = first;

            }
            Console.WriteLine(string.Join(" ", array));
            
        }
    }
}
