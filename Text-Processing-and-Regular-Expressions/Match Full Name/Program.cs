using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();

            MatchCollection names = Regex.Matches(rawInput, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match name in names)
            {
                Console.Write(name +" ");
            }
            Console.WriteLine();
        }
    }
}
