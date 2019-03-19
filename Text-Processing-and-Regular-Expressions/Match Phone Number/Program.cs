using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(rawInput, @"\+359([- ])2\1[0-9]{3}\1[0-9]{4}\b");

            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
