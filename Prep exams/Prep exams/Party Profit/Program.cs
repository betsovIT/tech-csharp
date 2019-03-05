using System;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int daysPast = 1;

            int coins = 0;

            while (daysPast <= days)
            {


                if (daysPast % 10 == 0)
                {
                    partySize -= 2;
                }
                if (daysPast % 15 == 0)
                {
                    partySize += 5;
                }
                coins += 50;
                coins -= partySize * 2;
                if (daysPast % 3 == 0)
                {
                    coins -= partySize * 3;
                }
                if (daysPast % 5 == 0)
                {
                    if (daysPast % 5 == 0 & daysPast % 3 == 0)
                    {
                        coins += 18 * partySize;
                        daysPast++;
                        continue;
                    }
                    coins += 20 * partySize;
                }

                daysPast++;

            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
