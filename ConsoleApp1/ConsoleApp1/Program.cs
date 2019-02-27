using System;

public class Program
{
    public static void Main()
    {
        string month = Console.ReadLine();
        double nights = double.Parse(Console.ReadLine());
        double end1 = 0;
        double end2 = 0;

        if (month == "May" || month == "Octomber")
        {
            if (nights > 7 && nights <= 14)
            {
                double Studio = 50 * 0.95;
                double Apartment = 65;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }
            else if (nights > 14)
            {
                double Studio = 50 * 0.7;
                double Apartment = 65 * 0.9;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }
            else
            {
                double Studio = 50;
                double Apartment = 65;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }


        }
        else if (month == "June" || month == "September")
        {
            if (nights > 14)
            {
                double Studio = 75.20 * 0.8;
                double Apartment = 68.70 * 0.9;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }
            else
            {
                end1 = nights * 75.20;
                end2 = nights * 68.70;
            }
        }
        else if (month == "July" || month == "August")
        {
            if (nights > 14)
            {
                double Studio = 76;
                double Apartment = 77 * 0.9;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }
            else
            {
                double Studio = 76;
                double Apartment = 77;
                end1 = nights * Studio;
                end2 = nights * Apartment;
            }
            
        }


        Console.WriteLine($"Apartment: {end2:f2} lv.");
        Console.WriteLine($"Studio: {end1:f2} lv.");

    }
}
