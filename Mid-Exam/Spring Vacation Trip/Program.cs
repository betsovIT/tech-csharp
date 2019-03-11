using System;

namespace Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupSize = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodPrice = double.Parse(Console.ReadLine());
            double roomPrice = double.Parse(Console.ReadLine());

            double totalExpenses = 0;

            double hotelExpenses = 0;
            double foodExpenses = 0;
            double fuelExpenses = 0;

            foodExpenses = groupSize * foodPrice * days;
            hotelExpenses = groupSize * roomPrice * days;

            if (groupSize > 10)
            {
                hotelExpenses = hotelExpenses * 0.75;
            }

            totalExpenses = hotelExpenses + foodExpenses;

            for (int i = 1; i <= days; i++)
            {
                if (totalExpenses > budget)
                {
                    Console.Write("Not enough money to continue the trip");
                    Console.WriteLine($". You need {totalExpenses - budget:F2}$ more.");
                    return;
                }

                totalExpenses += int.Parse(Console.ReadLine())*fuelPerKilometer;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpenses = totalExpenses * 1.4;
                }
                else if (i % 7 == 0)
                {
                    totalExpenses = totalExpenses - totalExpenses / groupSize;
                }
            }

            if (totalExpenses <= budget)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - totalExpenses:F2}$ budget left.");
            }

            if (totalExpenses > budget)
            {
                Console.Write("Not enough money to continue the trip");
                Console.WriteLine($". You need {totalExpenses - budget:F2}$ more.");
            }


        }
    }
}
