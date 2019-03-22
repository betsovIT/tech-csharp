using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Много грозна хватка със разделяне чрез табулация - в условието пише един или повече интервала...
            string[] input = Console.ReadLine().Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"^(?<firstLetter>[A-Za-z]{1})(?<num>\d+)(?<secondLetter>[A-Za-z]{1})$");

            decimal sum = 0M;

            for (int i = 0; i < input.Length; i++)
            {
                char firstLetter = char.Parse(regex.Match(input[i]).Groups["firstLetter"].Value);
                decimal num = decimal.Parse(regex.Match(input[i]).Groups["num"].Value);
                char secondLetter = char.Parse(regex.Match(input[i]).Groups["secondLetter"].Value);

                if (char.IsUpper(firstLetter))
                {
                    int position = (int)firstLetter - 64;
                    num = num / position;

                }
                else if (char.IsLower(firstLetter))
                {
                    int position = (int)firstLetter - 96;
                    num = num * position;
                }

                if (char.IsUpper(secondLetter))
                {
                    int position = (int)secondLetter - 64;
                    num = num - position;

                }
                else if (char.IsLower(secondLetter))
                {
                    int position = (int)secondLetter - 96;
                    num = num + position;
                }
                sum += num;
            }

            Console.WriteLine($"{sum:F2}");

        }
    }
}
