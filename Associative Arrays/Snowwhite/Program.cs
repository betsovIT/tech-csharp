using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, Dwarf>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ");
                if (input[0] == "Once upon a time")
                {
                    break;
                }

                string name = input[0];
                string hat = input[1];
                int physics = int.Parse(input[2]);

                if (!dwarfs.ContainsKey(name+hat))
                {
                    dwarfs.Add(name + hat, new Dwarf());
                    dwarfs[name + hat].Name = name;
                    dwarfs[name + hat].HatColor = hat;
                    dwarfs[name + hat].Physics = physics;
                }
                else
                {
                    if (dwarfs[name + hat].Physics < physics)
                    {
                        dwarfs[name + hat].Physics = physics;
                    }
                }
            }

            var sortedDwarfs = dwarfs.OrderByDescending(n => n.Value.Physics).ThenByDescending(n => n.Value.HatColor.Count());

            foreach (var item in sortedDwarfs)
            {
                Console.WriteLine($"({item.Value.HatColor}) {item.Value.Name} <-> {item.Value.Physics}");
            }
        }
    }


    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
}

