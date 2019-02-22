using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            string result = string.Join(" ", strList);
            List<int> endResult = result
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(string.Join(" ",endResult));
        }
    }
}
