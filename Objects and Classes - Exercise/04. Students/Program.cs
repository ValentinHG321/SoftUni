using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            List<Student> listStudents = new List<Student>();
            for (int i = 0; i < numberStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currentStudentFirstName = input[0];
                string currentStudentLastName = input[1];
                double currentStudentGrade = double.Parse(input[2]);

                Student currentStudent = new Student(currentStudentFirstName, currentStudentLastName, currentStudentGrade);
                listStudents.Add(currentStudent);
            }
            List<Student> sortedStudents = listStudents.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            
        }
    }

    class Student
    {
        public Student(string firstName, string lastName , double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Grade:F2}";
        }
    }
}
