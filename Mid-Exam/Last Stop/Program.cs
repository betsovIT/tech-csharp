using System;
using System.Collections.Generic;
using System.Linq;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split();

                if (command[0] == "Change")
                {
                    if (paintings.Contains(int.Parse(command[1])))
                    {
                        int index = paintings.FindIndex(n => n == int.Parse(command[1]));
                        paintings[index] = int.Parse(command[2]);
                    }
                }
                else if (command[0] == "Hide")
                {
                    if (paintings.Contains(int.Parse(command[1])))
                    {
                        paintings.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Switch")
                {
                    if (paintings.Contains(int.Parse(command[1])) && paintings.Contains(int.Parse(command[2])))
                    {
                        int firstIndex = paintings.FindIndex(n => n == int.Parse(command[1]));
                        int secondIndex = paintings.FindIndex(n => n == int.Parse(command[2]));

                        int valueholder = paintings[firstIndex];

                        paintings[firstIndex] = paintings[secondIndex];
                        paintings[secondIndex] = valueholder;
                    }
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1])+1 < paintings.Count)
                    {
                        paintings.Insert(int.Parse(command[1])+1, int.Parse(command[2]));
                    }
                    
                }
                else if (command[0] == "Reverse")
                {
                    paintings.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', paintings));
        }
    }
}
