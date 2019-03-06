using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] employeEfficiency = new int[3];
            for (int i = 0; i < employeEfficiency.Length; i++)
            {
                employeEfficiency[i] = int.Parse(Console.ReadLine());
            }

            int studentsCount = int.Parse(Console.ReadLine());
            int totalHourCounter = 0;
            int partialHourCounter = 0;

            while (studentsCount > 0)
            {
                
                
                if (partialHourCounter == 3)
                {
                    totalHourCounter++;
                    partialHourCounter = 0;
                    continue;
                }
                totalHourCounter++;
                partialHourCounter++;
                for (int i = 0; i < employeEfficiency.Length; i++)
                {
                    if (studentsCount > employeEfficiency[i])
                    {
                        studentsCount -= employeEfficiency[i];
                    }
                    else
                    {
                        studentsCount = 0;
                        break;
                    }
                }
            }
            Console.WriteLine($"Time needed: {totalHourCounter}h.");
        }
    }
}
