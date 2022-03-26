using System;
using System.Linq;


namespace _02._Common_Elements
{
    class Program
    {
        static void Main( )
        {
            string[] firstArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] secondArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


            for (int i = 0; i < firstArr.Length; i++)
            {
                string search = firstArr[i];
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (search == secondArr[j])
                    {
                        Console.Write(search);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}

