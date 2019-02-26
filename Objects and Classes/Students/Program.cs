using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] info = input.Split();

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
