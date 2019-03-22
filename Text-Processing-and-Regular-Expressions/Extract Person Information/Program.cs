using System;
using System.Text.RegularExpressions;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match matchName = Regex.Match(input, @"(?<=@)([A-Za-z]+)(?=\|)");
                Match matchAge = Regex.Match(input, @"(?<=#)(\d+)(?=\*)");

                if (matchName.Value != string.Empty && matchAge.Value != string.Empty)
                {
                    Console.WriteLine($"{matchName.Value} is {matchAge.Value} years old.");
                }                
            }
        }
    }
}
