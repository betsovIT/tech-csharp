using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", wagon));
                    break;
                }

                if (input[0] == "Add")
                {
                    wagon.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + int.Parse(input[0]) <= capacity)
                        {
                            wagon[i] += int.Parse(input[0]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
