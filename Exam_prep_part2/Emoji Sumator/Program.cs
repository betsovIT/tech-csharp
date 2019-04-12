using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string emoji = string.Empty;
            int[] emojyCode = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            int totalPower = 0;
            List<string> formatedEmojies = new List<string>();

            foreach (var code in emojyCode)
            {
                emoji += (char)code;
            }

            Regex regex = new Regex(@"(?<= :)[a-z]{4,}(?=:[ ,.!?])");

            MatchCollection emojies = regex.Matches(message);

            foreach (Match match in emojies)
            {
                foreach (var character in match.Value)
                {
                    totalPower += character;
                }
            }

            foreach (Match match in emojies)
            {
                if (match.Value == emoji)
                {
                    totalPower *= 2;
                }
            }

            foreach (Match match in emojies)
            {
                formatedEmojies.Add(':' + match.Value + ':');
            }

            if (emojies.Count != 0)
            {
                Console.WriteLine("Emojis found: " + string.Join(", ", formatedEmojies));
            }
            Console.WriteLine($"Total Emoji Power: {totalPower}");
        }
    }
}
