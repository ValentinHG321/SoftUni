using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] courseArgs = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = courseArgs[0];

                if (courseName == "end")
                {
                    break;
                }
                string studentName = courseArgs[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                courseInfo[courseName].Add(studentName);
            }
            PrintCoursesInfo(courseInfo);
        }
        static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
