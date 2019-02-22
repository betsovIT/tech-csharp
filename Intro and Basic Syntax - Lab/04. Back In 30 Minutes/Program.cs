using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine())+30;

            if (minutes >= 60)
            {
                minutes -= 60;
                hour++;
                if (hour > 23)
                {
                    hour -= 24;
                }
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
