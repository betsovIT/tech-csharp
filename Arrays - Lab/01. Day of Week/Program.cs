using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            try
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
