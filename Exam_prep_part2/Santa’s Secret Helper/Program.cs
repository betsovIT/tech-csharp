using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(?<=@)(?<name>[A-Za-z]+)[^@\-:>!]*!(?<behavior>[GB])!");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string childName = string.Empty;

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - key));
                }

                string decoded = sb.ToString();

                if (regex.IsMatch(decoded))
                {
                    if (regex.Match(decoded).Groups["behavior"].Value == "G")
                    {
                        Console.WriteLine(regex.Match(decoded).Groups["name"].Value);
                    }
                }
            }
        }
    }
}
