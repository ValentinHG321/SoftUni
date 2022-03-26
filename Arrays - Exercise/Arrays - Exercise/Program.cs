using System;
using System.Linq;
namespace _01_Train
{
    class Program
    {
        static void Main( )
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[wagons];
            int sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagons[i];
            }
            Console.WriteLine(String.Join(" ", peopleInWagons));
            Console.WriteLine(sum);
        }
    }
}
