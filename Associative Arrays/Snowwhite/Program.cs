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
            var dwarfsHatColors = new Dictionary<string, int>();

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
                    dwarfs.Add(name + hat, new Dwarf
                    {
                        Name = name,
                        HatColor = hat,
                        Physics = physics
                    });

                    if (!dwarfsHatColors.ContainsKey(hat))
                    {
                        dwarfsHatColors.Add(hat, 0);
                    }
                    dwarfsHatColors[hat]++;
                }
                else
                {
                    if (dwarfs[name + hat].Physics < physics)
                    {
                        dwarfs[name + hat].Physics = physics;
                    }
                }
            }

            var sortedDwarfs = dwarfs
                .OrderByDescending(n => n.Value.Physics)
                .ThenByDescending(n => dwarfsHatColors[n.Value.HatColor]);            

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

