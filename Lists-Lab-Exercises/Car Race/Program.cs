using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> track = Console.ReadLine().Split().Select(double.Parse).ToList();
            double leftRacerTime = 0;
            double rightRacerTime = 0;

            List<double> rightRacer = new List<double>();
            List<double> leftRacer = new List<double>();

            for (int i = 0; i < track.Count / 2; i++)
            {
                leftRacer.Add(track[i]);
            }
            for (int i = track.Count / 2 + 1; i < track.Count; i++)
            {
                rightRacer.Add(track[i]);
            }
            rightRacer.Reverse();

            for (int i = 0; i < leftRacer.Count; i++)
            {
                leftRacerTime += leftRacer[i];
                if (leftRacer[i] == 0)
                {
                    leftRacerTime = leftRacerTime * 0.8;
                }
            }
            for (int i = 0; i < rightRacer.Count; i++)
            {
                rightRacerTime += rightRacer[i];
                if (rightRacer[i] == 0)
                {
                    rightRacerTime = rightRacerTime * 0.8;
                }
            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }

        }
    }
}
