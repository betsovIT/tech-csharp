using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initDrumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> manipulatedSet = new List<int>();
            manipulatedSet.AddRange(initDrumSet);

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int damage = int.Parse(input);

                for (int i = 0; i < manipulatedSet.Count; i++)
                {
                    manipulatedSet[i] -= damage;
                    if (manipulatedSet[i] <= 0)
                    {
                        if (savings - 3 * initDrumSet[i] < 0)
                        {
                            initDrumSet.RemoveAt(i);
                            manipulatedSet.RemoveAt(i);

                            i--;

                            continue;
                        }
                        else
                        {
                            manipulatedSet[i] = initDrumSet[i];
                            savings -= initDrumSet[i] * 3;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", manipulatedSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");

        }
    }
}
