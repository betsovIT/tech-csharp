using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string course = input.Split(" : ")[0];
                string person = input.Split(" : ")[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(person);

                input = Console.ReadLine();
            }

            foreach (var item in courses)
            {
                item.Value.Sort();
            }

            var orderedCourses = courses.OrderByDescending(n => n.Value.Count);

            foreach (var item in orderedCourses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var person in item.Value)
                {
                    Console.WriteLine($"-- {person}");
                }
            }

        }
    }
}
