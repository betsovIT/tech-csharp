using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new Dictionary<string, int>();
            var presents = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input.Split("->")[0] != "Remove")
                {
                    string child = input.Split("->")[0];
                    string toy = input.Split("->")[1];
                    int ammount = int.Parse(input.Split("->")[2]);

                    if (!children.ContainsKey(child))
                    {
                        children.Add(child,0);
                    }                
                    children[child] += ammount;

                    if (!presents.ContainsKey(toy))
                    {
                        presents.Add(toy, 0);
                    }
                    presents[toy] += ammount;
                }
                else
                {
                    string child = input.Split("->")[1];
                    children.Remove(child);
                }                
            }
            Console.WriteLine("Children:");
            foreach (var child in children.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var present in presents)
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }
        }
    }
}
