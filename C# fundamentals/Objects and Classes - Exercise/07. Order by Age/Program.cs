using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{   
    class AgeOrder
    {
        public AgeOrder(string name , int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string output = $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
            return output;
        }
    }
    internal class Program
    {
        static void Main()
        {
            string end = string.Empty;
            List<AgeOrder> AgeList = new List<AgeOrder>();
            while ((end = Console.ReadLine()) != "End")
            {
                string[] Arr = end.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = Arr[0];
                int id = int.Parse(Arr[1]);
                int age = int.Parse(Arr[2]);

                AgeOrder ageOrder = new AgeOrder(name, id, age);
                AgeList.Add(ageOrder);
            }
            //List<Team> teamsWithMembers = teams
            //    .Where(t => t.Members.Count > 0)
            //    .OrderByDescending(t => t.Members.Count)
            //    .ThenBy(t => t.Name)
            //    .ToList();

            List<AgeOrder> orderedList = AgeList.OrderBy(t=> t.Age).ToList();
            foreach (AgeOrder ageOrder in orderedList)
            {
                Console.WriteLine(ageOrder);
            }
        }
    }
}
