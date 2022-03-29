using System;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, double> studentGradeBook = new Dictionary<string, double>();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGradeBook.ContainsKey(name))
                {
                    studentGradeBook[name] += grade;
                    studentGradeBook[name] /= 2;
                }
                else
                {
                    studentGradeBook.Add(name, grade);
                }
            }
            foreach (var name in studentGradeBook)
            {
                if (name.Value < 4.5)
                {
                    studentGradeBook.Remove(name.Key);
                }
            }

            foreach(var name in studentGradeBook)
            {
                Console.WriteLine($"{name.Key} -> {name.Value:F2}");
            }
        }
    }
}
