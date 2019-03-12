using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var valuableMaterials = new Dictionary<string, int>
            {
                {"shards",0 },
                { "fragments",0 },
                {"motes",0  },
            };
            var junkMaterials = new SortedDictionary<string, int>();

            bool hasLegendary = false;

            while (true)
            {
                string[] loot = input.Split().Select(n => n.ToLower()).ToArray();

                for (int i = 0; i < loot.Length; i += 2)
                {
                    int quantity = int.Parse(loot[i]);
                    string material = loot[i + 1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        valuableMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }

                    if (valuableMaterials.ContainsKey("shards") && valuableMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        valuableMaterials["shards"] -= 250;
                        hasLegendary = true;
                        break;
                    }
                    else if (valuableMaterials.ContainsKey("fragments") && valuableMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        valuableMaterials["fragments"] -= 250;
                        hasLegendary = true;
                        break;
                    }
                    else if (valuableMaterials.ContainsKey("motes") && valuableMaterials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        valuableMaterials["motes"] -= 250;
                        hasLegendary = true;
                        break;
                    }
                }

                if (hasLegendary)
                {
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }

            }
            valuableMaterials.OrderByDescending(n => n.Value).ThenBy(n => n.Key).ToDictionary(n => n.Key, n=> n.Value);

            var valuableMaterialsSorted = valuableMaterials.OrderByDescending(n => n.Value).ThenBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);

            foreach (var valuable in valuableMaterialsSorted)
            {
                Console.WriteLine($"{valuable.Key}: {valuable.Value}");
            }
            foreach (var junk in junkMaterials)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
