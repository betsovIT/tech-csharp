using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> removedPokemons = new List<int>();

            while (pokemons.Count > 0)
            {
                int position = int.Parse(Console.ReadLine());
                bool defaultedToFrist = false;
                bool defaultedToLast = false;

                if (position < 0)
                {
                    position = 0;
                    defaultedToFrist = true;
                }
                else if (position >= pokemons.Count)
                {
                    position = pokemons.Count - 1;
                    defaultedToLast = true;
                }

                int elementValue = pokemons[position];
                removedPokemons.Add(pokemons[position]);
                pokemons.RemoveAt(position);

                if (defaultedToFrist )
                {
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    //pokemons.RemoveAt(1);
                }

                if (defaultedToLast )
                {
                    pokemons.Add(pokemons[0]);
                    //pokemons.RemoveAt(pokemons.Count - 2);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= elementValue)
                    {
                        pokemons[i] += elementValue;
                    }
                    else
                    {
                        pokemons[i] -= elementValue;
                    }
                }

                
            }

            Console.WriteLine(removedPokemons.Sum());
        }
    }
}
