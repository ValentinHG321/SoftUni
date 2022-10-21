using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main()
        {
            int charMaxLenght = int.Parse(Console.ReadLine());

            List<string> namesList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> namesFiltered = new List<string>();

            Func<string, int, bool> filterFunc = (name, max) =>
           {
               bool check = false;
               int ch = 0;

               foreach (char item in name)
               {

                   ch += item;

                   if (ch >= max)
                   {
                       check = true;
                   }
               }
               return check;
           };

            foreach (var name in namesList)
            {
                if (filterFunc(name,charMaxLenght))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}
