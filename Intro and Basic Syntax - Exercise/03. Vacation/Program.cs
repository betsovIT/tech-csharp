using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = -1;
            double percentDiscount = 1;
            double flatDiscount = 0;

            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 8.45;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 10.9;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 9.8;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 15.6;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 10.46;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 16;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 22.5;
                }
            }

            if (groupType == "Students" && visitors >= 30)
            {
                percentDiscount = 0.85;
            }

            if (groupType == "Business" && visitors >= 100)
            {
                flatDiscount = 10 * pricePerPerson;
            }

            if (groupType == "Regular" && (visitors >= 10 && visitors <= 20))
            {
                percentDiscount = 0.95;
            }

            Console.WriteLine($"Total price: {(visitors * pricePerPerson * percentDiscount - flatDiscount):F2}");
        }
    }
}
