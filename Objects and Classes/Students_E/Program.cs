using System;
using System.Collections.Generic;

namespace Students_E
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                

                string[] input = Console.ReadLine().Split();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);

                students.Add(student);                
            }
            students.Sort((x, y) => x.Grade.CompareTo(y.Grade));
            students.Reverse();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
