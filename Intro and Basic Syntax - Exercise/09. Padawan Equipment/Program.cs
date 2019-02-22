using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltrPrice = double.Parse(Console.ReadLine());

            double totalLightsaberPrice = Math.Ceiling(students * 1.1) * lightsaberPrice;
            double totalRobePrice = students * robePrice;
            double totalBeltPrice = (students - (Math.Floor((double)students / 6))) * beltrPrice;
            double sum = totalBeltPrice + totalLightsaberPrice + totalRobePrice;

            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(sum-money):F2}lv more.");
            }
        }
    }
}
