using System;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ' };
            string[] tickets = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Match matchLeft = Regex.Match(ticket.Substring(0,10), @"@{6,}|\${6,}|#{6,}|\^{6,}");
                Match matchRight = Regex.Match(ticket.Substring(10, 10), @"@{6,}|\${6,}|#{6,}|\^{6,}");

                if (matchLeft.Success && matchRight.Success && matchLeft.Value == matchRight.Value)
                {
                    var winningSymbol = matchLeft.Value[0];
                    var winningStreakLength = Math.Min(matchLeft.Value.Length, matchRight.Value.Length);
                    if (winningStreakLength == 10)
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - {winningStreakLength}{winningSymbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - {winningStreakLength}{winningSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }

            }
        }
    }
}
