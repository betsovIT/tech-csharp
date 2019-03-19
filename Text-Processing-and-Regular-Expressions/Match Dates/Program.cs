using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(rawInput, @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})");

            foreach (Match date in matches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
