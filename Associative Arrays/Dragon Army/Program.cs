using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, Dragon>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string type = input[0];
                string name = input[1];
                string damageString = input[2];
                string healthString = input[3];
                string armorString = input[4];

                int damage = ParseInput(damageString, 45);
                int health = ParseInput(healthString, 250);
                int armor = ParseInput(armorString, 10);

                string dragonKey = name + type;
                
                if (dragons.ContainsKey(dragonKey))
                {
                    var dragon = dragons[dragonKey];

                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                }
                else
                {
                    Dragon dragon = new Dragon
                    {
                        Name = name,
                        Type = type,
                        Damage = damage,
                        Health = health,
                        Armor = armor
                    };
                    dragons.Add(dragonKey, dragon);
                }
            }

            var sortedDragons = dragons.GroupBy(
                d => d.Value.Type,
                (key, g) => new
                {
                    Color = key,
                    AverageHealth = g.Average(d => d.Value.Health),
                    AverageDamage = g.Average(d => d.Value.Damage),
                    AverageArmor = g.Average(d => d.Value.Armor),
                    Dragons = g.Select(x => x.Value).ToList()
                });

            foreach (var colorGroup in sortedDragons)
            {
                Console.WriteLine($"{colorGroup.Color}::({colorGroup.AverageDamage:F2}/{colorGroup.AverageHealth:F2}/{colorGroup.AverageArmor:F2})");
                foreach (var dragon in colorGroup.Dragons.OrderBy(n => n.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        private static int ParseInput(string input, int defaultValue)
        {
            int result;
            if (input != "null")
            {
                result = int.Parse(input);
            }
            else
            {
                result = defaultValue;
            }

            return result;
        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
