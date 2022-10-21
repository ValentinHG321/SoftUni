using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {

                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];
                bool doesStudentExists = DoesStudentExists(students, firstName, lastName);

                if (doesStudentExists)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;  
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown);
                    students.Add(newStudent);
                }
            }

            string searchCity = Console.ReadLine();

            List<Student> filtered = students.FindAll(x => x.HomeTown == searchCity);
            foreach (Student town in filtered)
            {
                Console.WriteLine($"{town.FirstName} {town.LastName} is {town.Age} years old.");
            }
        }

        static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool DoesStudentExists(List<Student> students , string firstName ,string lastName)
        {
            foreach (Student student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;   
        }
    }
}

