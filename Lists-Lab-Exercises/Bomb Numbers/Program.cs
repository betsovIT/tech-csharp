using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bombNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] parameters = Console.ReadLine().Split();
            int bomb = int.Parse(parameters[0]);
            int positions = int.Parse(parameters[1]);

            for (int i = 0; i < bombNums.Count; i++)
            {
                if (bombNums[i] == bomb)
                {
                    bombNums[i] = 0;

                    for (int j = 0; j < bombNums.Count; j++)
                    {

                    }
                }
            }
        }
    }
}
