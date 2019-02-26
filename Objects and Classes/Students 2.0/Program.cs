using System;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] info = input.Split();

                bool nextStudent = false;

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].firstName == info[0] && students[i].lastName == info[1])
                    {
                        students[i].age = int.Parse(info[2]);
                        students[i].hometown = info[3];
                        nextStudent = true;
                        break;
                    }
                }

                if (nextStudent)
                {
                    input = Console.ReadLine();
                    continue;
                }

                Student student = new Student();

                student.firstName = info[0];
                student.lastName = info[1];
                student.age = int.Parse(info[2]);
                student.hometown = info[3];

                students.Add(student);

                input = Console.ReadLine();
            }

            string townToPrint = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.hometown == townToPrint)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string hometown { get; set; }
    }
}
