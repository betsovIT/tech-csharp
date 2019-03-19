using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"([\D]+)([0-9]+)");

            StringBuilder uniques = new StringBuilder();

            foreach (Match match in matches)
            {
                uniques.Append(match.Groups[1].Value.ToLower());
            }

            int uniqueCharCounter = uniques.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueCharCounter}");
            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value.ToUpper();
                int repeatCounter = int.Parse(match.Groups[2].Value);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < repeatCounter; i++)
                {
                    sb.Append(text);
                }
                Console.Write(sb);
            }
            Console.WriteLine();

        }
    }
}
