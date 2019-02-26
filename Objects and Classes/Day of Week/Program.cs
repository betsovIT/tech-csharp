using System;
using System.Globalization;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime inputAsDateTime = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(inputAsDateTime.DayOfWeek);
        }
    }
}
