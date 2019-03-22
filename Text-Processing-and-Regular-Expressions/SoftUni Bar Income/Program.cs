using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<name>%[A-Z]{1}[a-z]+%)()[^|$%.]*(?<product><\w+>)[^|$%.]*(?<count>\|\d+\|)[^|$%.]*?(?<price>\d+[\.\d]*\$)");
            double totalIncome = 0;

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

                    string customerNameRaw = match.Groups["name"].Value;
                    string customerName = customerNameRaw.Substring(1, customerNameRaw.Length - 2);
                    string productRaw = match.Groups["product"].Value;
                    string product = productRaw.Substring(1, productRaw.Length - 2);
                    string countRaw = match.Groups["count"].Value;
                    int count = int.Parse(countRaw.Substring(1, countRaw.Length - 2));
                    string priceRaw = match.Groups["price"].Value;
                    double price = double.Parse(priceRaw.Substring(0,priceRaw.Length-1));

                    double income = count * price;
                    totalIncome += income;

                    Console.WriteLine($"{customerName}: {product} - {income:F2}");

                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
