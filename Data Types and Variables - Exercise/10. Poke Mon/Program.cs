using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint pokePower = uint.Parse(Console.ReadLine());
            uint distBetweenTargets = uint.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            uint originalPokePower = pokePower;

            short targetCounter = 0;

            while (pokePower >= distBetweenTargets)
            {
                if (pokePower == originalPokePower / 2)
                {
                    pokePower = pokePower / exhaustionFactor;
                    if (pokePower < distBetweenTargets)
                    {
                        break;
                    }
                }
                pokePower -= distBetweenTargets;
                targetCounter++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCounter);

        }
    }
}
