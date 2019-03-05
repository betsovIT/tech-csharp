using System;
using System.Collections.Generic;
using System.Linq;

namespace Grains_of_Sand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sandWatches = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "Mort")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    sandWatches.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (sandWatches.Contains(int.Parse(command[1])))
                    {
                        sandWatches.Remove(int.Parse(command[1]));
                    }
                    else
                    {
                        if (int.Parse(command[1]) < sandWatches.Count)
                        {
                            sandWatches.RemoveAt(int.Parse(command[1]));
                        }
                    }
                }
                else if (command[0] == "Replace")
                {
                    if (sandWatches.Contains(int.Parse(command[1])))
                    {
                        int tempIndex = sandWatches.FindIndex(n => n == int.Parse(command[1]));
                        sandWatches[tempIndex] = int.Parse(command[2]);
                    }
                }
                else if (command[0] == "Increase")
                {
                    int value = int.Parse(command[1]);
                    if (sandWatches.Exists(n => n >= value))
                    {
                        int index = sandWatches.FindIndex(n => n >= value);
                        int valueToIncrease = sandWatches[index];

                        for (int i = 0; i < sandWatches.Count; i++)
                        {
                            sandWatches[i] += valueToIncrease;
                        }
                    }
                    else
                    {
                        int valueToIncrease = sandWatches[sandWatches.Count - 1];
                        for (int i = 0; i < sandWatches.Count; i++)
                        {
                            sandWatches[i] += valueToIncrease;
                        }
                    }                    
                }
                else if (command[0] == "Collapse")
                {
                    for (int i = 0; i < sandWatches.Count; i++)
                    {
                        if (sandWatches[i] < int.Parse(command[1]))
                        {
                            sandWatches.RemoveAt(i);
                            i--;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",sandWatches));
        }
    }
}
