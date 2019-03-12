using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();

            int position = 0;

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Forward")
                {
                    if (position + int.Parse(command[1]) < houses.Count)
                    {
                        position += int.Parse(command[1]);
                        houses.RemoveAt(position);
                        //if (position >= houses.Count)
                        //{
                        //    position = houses.Count - 1;
                        //}
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "Back")
                {
                    if (position - int.Parse(command[1]) > -1)
                    {
                        position -= int.Parse(command[1]);
                        houses.RemoveAt(position);
                        //if (position >= houses.Count)
                        //{
                        //    position = houses.Count - 1;
                        //}
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "Gift")
                {
                    if (int.Parse(command[1]) >= houses.Count || int.Parse(command[1]) < 0)
                    {
                        if (int.Parse(command[1]) == houses.Count)
                        {
                            houses.Add(int.Parse(command[2]));
                        }                        
                        continue;
                    }
                    houses.Insert(int.Parse(command[1]), int.Parse(command[2]));
                    position = int.Parse(command[1]);
                }
                else if (command[0] == "Swap")
                {
                    if (houses.Contains(int.Parse(command[1])) && houses.Contains(int.Parse(command[2])))
                    {
                        int firstValueIndex = houses.FindIndex(n => n == int.Parse(command[1]));
                        int secondValueIndex = houses.FindIndex(n => n == int.Parse(command[2]));

                        int valueholder = houses[firstValueIndex];

                        houses[firstValueIndex] = houses[secondValueIndex];
                        houses[secondValueIndex] = valueholder;
                    }
                    
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ",houses));
        }
    }
}
