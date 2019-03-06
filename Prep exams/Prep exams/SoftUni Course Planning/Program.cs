using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(':');

                if (command[0] == "Add")
                {
                    course.Add(command[1]);
                }
                else if (command[0] == "Insert")
                {
                    if (!course.Contains(command[1]) && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < course.Count)
                    {
                        course.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    course.Remove(command[1]);
                    course.Remove(command[1] + "-Exercise");
                }
                else if (command[0] == "Swap")
                {
                    if (course.Contains(command[1]) && course.Contains(command[2]))
                    {
                        int firstIndex = course.FindIndex(n => n == command[1]);
                        int secondIndex = course.FindIndex(n => n == command[2]);

                        if (!course.Contains(command[1]+"-Exercise") && !course.Contains(command[2] + "-Exercise"))
                        {
                            string tempstring = course[firstIndex];
                            course[firstIndex] = course[secondIndex];
                            course[secondIndex] = tempstring;
                        }
                        else if (course.Contains(command[1] + "-Exercise") && course.Contains(command[2] + "-Exercise"))
                        {
                            string tempstring = course[firstIndex];
                            course[firstIndex] = course[secondIndex];
                            course[secondIndex] = tempstring;

                            course[firstIndex+1] = course[secondIndex+1];
                            course[secondIndex+1] = tempstring + "-Exercise";
                        }
                        else if (!course.Contains(command[1] + "-Exercise") && course.Contains(command[2] + "-Exercise"))
                        {
                            string tempstring = course[firstIndex];
                            course[firstIndex] = course[secondIndex];
                            course[secondIndex] = tempstring;

                            course.Insert(firstIndex + 1, course[secondIndex] + "-Exercise");
                            course.RemoveAt(secondIndex + 1);
                        }
                        else if (course.Contains(command[1] + "-Exercise") && !course.Contains(command[2] + "-Exercise"))
                        {
                            string tempstring = course[firstIndex];
                            course[firstIndex] = course[secondIndex];
                            course[secondIndex] = tempstring;

                            course.Insert(secondIndex + 1, course[firstIndex] + "-Exercise");
                            course.RemoveAt(firstIndex + 1);
                        }
                    }
                }
                else if (command[0] == "Exercise")
                {
                    if (!course.Contains(command[1]))
                    {
                        course.Add(command[1]);
                        course.Add(command[1] + "-Exercise");
                    }
                    else if (course.Contains(command[1]) && !course.Contains(command[1] + "-Exercise"))
                    {
                        int index = course.FindIndex(n => n == command[1]);
                        course.Insert(index + 1, command[1] + "-Exercise");
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{course[i]}");
            }
        }
    }
}
