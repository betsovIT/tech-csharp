using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double newHeadsets = Math.Floor((double)lostGames / 2);
            double newMouses = Math.Floor((double)lostGames / 3);
            double newKeyboards = Math.Floor((double)lostGames / 6);
            double newDisplays = Math.Floor((double)lostGames / 12);

            double sum = newHeadsets * headsetPrice + newDisplays * displayPrice + newKeyboards * keyboardPrice + newMouses * mousePrice;

            Console.WriteLine($"Rage expenses: {sum:F2} lv.");

        }
    }
}
