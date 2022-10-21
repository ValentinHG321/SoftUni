using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string name = data.Split(' ')[0];
                int age = int.Parse(data.Split(' ')[1]);

                Person person = new Person(name, age);
                if (person.Age > 30)
                {
                    list.Add(person);
                }

            }

            list = list.OrderBy(x => x.Name).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

        }
    }
}
