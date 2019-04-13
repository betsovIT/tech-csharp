using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<name>%[A-Z]{1}[a-z]+%)[^|%$.]*(?<product><[\w]+>)[^|%$.]*(?<quantity>\|\d+\|)[^|%$.]*?(?<price>\d+\.?\d*)\$");

            double totalSum = 0;

            var culture = CultureInfo.InvariantCulture;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string customer = match.Groups["name"].Value.Substring(1, match.Groups["name"].Value.Length - 2);
                    string product = match.Groups["product"].Value.Substring(1, match.Groups["product"].Value.Length - 2);
                    int quantiy = int.Parse(match.Groups["quantity"].Value.Substring(1, match.Groups["quantity"].Value.Length - 2));
                    double price = double.Parse(match.Groups["price"].Value, culture);

                    totalSum += quantiy * price;

                    Console.WriteLine($"{customer}: {product} - {quantiy * price:F2}");
                }
            }
            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
