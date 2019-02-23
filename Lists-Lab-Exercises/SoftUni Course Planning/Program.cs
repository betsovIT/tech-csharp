using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.None).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(':');
                if (input[0] == "course start")
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        Console.WriteLine($"{i+1}.{schedule[i]}");
                    }
                    break;
                }
                if (input[0] == "Add")
                {
                    if (!schedule.Contains(input[1]))
                    {
                        schedule.Add(input[1]);
                    }
                }
                else if (input[0] == "Insert")
                {
                    if (!schedule.Contains(input[1]))
                    {
                        schedule.Insert(int.Parse(input[2]), input[1]);
                    }
                }
                else if (input[0] == "Remove")
                {
                    schedule.Remove(input[1]);
                    schedule.Remove(input[1]+"-Exercises");
                }
                else if (input[0] == "Exercise")
                {
                    if (schedule.Contains(input[0]) && !schedule.Contains(input[0]+"-Exercises"))
                    {
                        schedule.Insert(schedule.FindIndex(n => n == input[0]), input[0] + "-Exercises");
                    }
                    else if (!schedule.Contains(input[0]) && !schedule.Contains(input[0] + "-Exercises"))
                    {
                        schedule.Add(input[1]);
                        schedule.Add(input[1] + "-Exercises");
                    }
                }
                else if (input[0] == "Swap")
                {
                    if (schedule.Contains(input[1]) 
                            && schedule.Contains(input[2])
                                && !schedule.Contains(input[1]+"-Exercises")
                                    && !schedule.Contains(input[2] + "-Exercises"))
                    {
                        int firstLesonIndex = schedule.FindIndex(n => n == input[1]);
                        int secondLesonIndex = schedule.FindIndex(n => n == input[2]);
                        string swapFirst = schedule[firstLesonIndex];
                        string swapSecond = schedule[secondLesonIndex];

                        schedule[firstLesonIndex] = swapSecond;
                        schedule[secondLesonIndex] = swapFirst;
                    }
                    else if (schedule.Contains(input[1])
                            && schedule.Contains(input[2])
                                && schedule.Contains(input[1] + "-Exercises")
                                    && !schedule.Contains(input[2] + "-Exercises"))
                    {
                        int firstLesonIndex = schedule.FindIndex(n => n == input[1]);
                        int secondLesonIndex = schedule.FindIndex(n => n == input[2]);
                        string swapFirst = schedule[firstLesonIndex];
                        string swapSecond = schedule[secondLesonIndex];

                        schedule[firstLesonIndex] = swapSecond;
                        schedule.RemoveAt(firstLesonIndex + 1);
                        schedule[secondLesonIndex] = swapFirst;
                        schedule.Insert(secondLesonIndex + 1, swapFirst + "-Exercises");
                    }
                }
            }
        }        
    }
}
