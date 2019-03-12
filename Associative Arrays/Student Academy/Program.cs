using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesToRead = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < linesToRead; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }

                students[student].Add(grade);
            }

            var goodStudents = new Dictionary<string, List<double>>();

            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.5)
                {
                    goodStudents.Add(item.Key,item.Value);
                }
            }

            var orderedGoodStudents = goodStudents.OrderByDescending(n => n.Value.Average());
            foreach (var item in orderedGoodStudents)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }
        }
    }
}
