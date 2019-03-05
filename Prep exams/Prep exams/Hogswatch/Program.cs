using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int initPresents = int.Parse(Console.ReadLine());
            int currentPresents = initPresents;

            int[] homes = new int[homesToVisit];
            int returnCounter = 0;
            int totalAditionalPresents = 0;

            int visitedHomes = 0;
            int additionalPresents = 0;

            for (int i = 0; i < homesToVisit; i++)
            {
                homes[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < homes.Length; i++)
            {
                if (currentPresents >= homes[i])
                {
                    currentPresents -= homes[i];
                    visitedHomes++;
                    continue;
                }
                if (currentPresents < homes[i])
                {
                    returnCounter++;
                    additionalPresents = homes[i] - currentPresents;
                    homes[i] -= currentPresents;
                    visitedHomes++;
                    currentPresents = initPresents / visitedHomes * (homes.Length - visitedHomes) + additionalPresents;
                    totalAditionalPresents += currentPresents;
                    visitedHomes--;
                    i--;

                }
            }
            if (returnCounter == 0)
            {
                Console.WriteLine(currentPresents);
            }
            else
            {
                Console.WriteLine(returnCounter);
                Console.WriteLine(totalAditionalPresents);
            }
        }
    }
}
