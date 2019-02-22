using System;
using System.Collections.Generic;
using System.Linq;

namespace Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> characters = new List<char>();
            List<double> numbers = new List<double>();
            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > 47 && (int)input[i] < 58)
                {
                    numbers.Add(char.GetNumericValue(input[i]));
                }
                else
                {
                    characters.Add(input[i]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 ==0)
                {
                    take.Add((int)numbers[i]);
                }
                else
                {
                    skip.Add((int)numbers[i]);
                }
            }
            int commandLength = take.Count;
            int currPossition = 0;
            string ressult = "";

            for (int i = 0; i < commandLength; i++)
            {
                for (int j = currPossition; j < Math.Min((currPossition + take[i]),characters.Count); j++)
                {
                    ressult += characters[j];
                }
                currPossition += take[i];
                currPossition += skip[i];
            }
            Console.WriteLine(ressult);

        }
    }
}
