using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',' };
            string[] demons = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var demonStats = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < demons.Length; i++)
            {
                string demonName = demons[i];
                double health = 0;
                double damage = 0;

                for (int j = 0; j < demonName.Length; j++)
                {
                    if ((demonName[j]<45 || demonName[j]>57) && demonName[j] != 42 && demonName[j] != 43)
                    {
                        health += demonName[j];
                    }
                }

                MatchCollection matches = Regex.Matches(demonName, @"-?\d+\.?\d*");
                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value.ToString());
                }

                for (int j = 0; j < demonName.Length; j++)
                {
                    if (demonName[j] == '*')
                    {
                        damage = damage * 2;
                    }
                    else if (demonName[j] == '/')
                    {
                        damage = damage / 2;
                    }
                }
                demonStats.Add(demonName, new List<double> { health, damage });                
            }
            foreach (var demon in demonStats)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]:F0} health, {demon.Value[1]:F2} damage");
            }
            
        }
    }
}
