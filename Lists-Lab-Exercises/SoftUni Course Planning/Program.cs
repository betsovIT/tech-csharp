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
                        Console.WriteLine($"{i + 1}.{schedule[i]}");
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
                    schedule.Remove(input[1] + "-Exercise");
                }
                else if (input[0] == "Exercise")
                {
                    if (schedule.Contains(input[1]) && !schedule.Contains(input[1] + "-Exercise"))
                    {
                        schedule.Insert(schedule.FindIndex(n => n == input[1])+1, input[1] + "-Exercise");
                    }
                    else if (!schedule.Contains(input[1]) && !schedule.Contains(input[1] + "-Exercise"))
                    {
                        schedule.Add(input[1]);
                        schedule.Add(input[1] + "-Exercise");
                    }
                }
                else if (input[0] == "Swap")
                {
                    if (schedule.Contains(input[1]) && schedule.Contains(input[2]))
                    {
                        int firstIndex = schedule.FindIndex(n => n == input[1]);
                        int secondIndex = schedule.FindIndex(n => n == input[2]);

                        if (!schedule.Contains(input[1] + "-Exercise") && !schedule.Contains(input[2] + "-Exercise"))
                        {
                            Swap(firstIndex, secondIndex, schedule);
                        }
                        else if (schedule.Contains(input[1] + "-Exercise") && schedule.Contains(input[2] + "-Exercise"))
                        {
                            Swap(firstIndex, secondIndex, schedule);
                            Swap(firstIndex + 1, secondIndex + 1, schedule);

                        }
                        else if (!schedule.Contains(input[1] + "-Exercise") && schedule.Contains(input[2] + "-Exercise"))
                        {
                            Swap(firstIndex, secondIndex, schedule);
                            schedule.RemoveAt(secondIndex + 1);

                            if (firstIndex + 1 >= schedule.Count)
                            {
                                schedule.Add(input[2] + "-Exercise");
                            }
                            else
                            {
                                schedule.Insert(firstIndex + 1, input[2] + "-Exercise");
                            }
                        }
                        else if (schedule.Contains(input[1] + "-Exercise") && !schedule.Contains(input[2] + "-Exercise"))
                        {
                            Swap(firstIndex, secondIndex, schedule);
                            schedule.RemoveAt(firstIndex + 1);

                            if (secondIndex + 1 >= schedule.Count)
                            {
                                schedule.Add(input[1] + "-Exercise");
                            }
                            else
                            {
                                schedule.Insert(secondIndex + 1, input[1] + "-Exercise");
                            }
                        }



                    }
                }
            }
        }

        static void Swap(int index1, int index2, List<string> list)
        {
            string firstString = list[index1];
            string secondString = list[index2];

            list[index1] = secondString;
            list[index2] = firstString;
        }
    }
}
