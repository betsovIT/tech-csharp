using System;
using System.Text.RegularExpressions;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();

            string capitalLettersRaw = rawInput.Split('|')[0];
            string wordLengthsRaw = rawInput.Split('|')[1];
            string wordsToCheckRaw = rawInput.Split('|')[2];

            Regex regexCapitalLetters = new Regex(@"(?<=([#$%&]))[A-Z]+(?=\1)");
            Regex regexWordLengths = new Regex(@"(?<letter>[\d]{2}):(?<length>[\d]{2})");
            Regex regexWordsToCheck = new Regex(@"\b[A-Z]{1}[\S]+\b");

            string capitalLetters = regexCapitalLetters.Match(capitalLettersRaw).Value;
            MatchCollection wordLengths = regexWordLengths.Matches(wordLengthsRaw);
            MatchCollection wordsToCheck = regexWordsToCheck.Matches(wordsToCheckRaw);


            foreach (Match word in wordsToCheck)
            {
                bool correctCapLetter = false;
                bool correctLength = false;

                foreach (var letter in capitalLetters)
                {
                    if (letter == word.Value[0])
                    {
                        correctCapLetter = true;
                        break;
                    }
                }

                foreach (Match rule in wordLengths)
                {
                    if (word.Value[0] == (char)int.Parse(rule.Groups["letter"].Value) && word.Value.Length == int.Parse(rule.Groups["length"].Value) + 1)
                    {
                        correctLength = true;
                    }

                }

                if (correctCapLetter && correctLength)
                {
                    Console.WriteLine(word.Value);
                }
            }
        }
    }
}
