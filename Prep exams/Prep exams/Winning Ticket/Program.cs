using System;
using System.Collections.Generic;
using System.Linq;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ' };
            List<string> tickets = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < tickets.Count; i++)
            {
                int leftSymbols = 1;
                int rightSymbols = 1;

                int maxRight = 1;
                int maxLeft = 1;

                char lastLeftSymbol = 'a';
                char lastRightSymbol = 'b';

                bool newSequence = false;

                if (tickets[i].Length == 20)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (tickets[i][j] == tickets[i][j+1] && (tickets[i][j] == '@' || tickets[i][j] == '#' || tickets[i][j] == '$' || tickets[i][j] == '^'))
                        {
                            leftSymbols++;
                            lastLeftSymbol = tickets[i][j];
                        }
                        if (leftSymbols > maxLeft)
                        {
                            maxLeft = leftSymbols;
                            lastLeftSymbol = tickets[i][j];
                        }
                        else
                        {
                            leftSymbols = 0;
                        }
                    }
                    for (int j = 10; j < 19; j++)
                    {
                        if (tickets[i][j] == tickets[i][j + 1] && (tickets[i][j] == '@' || tickets[i][j] == '#' || tickets[i][j] == '$' || tickets[i][j] == '^'))
                        {
                            rightSymbols++;
                            lastRightSymbol = tickets[i][j];
                        }
                        if (rightSymbols > maxRight)
                        {
                            maxRight = rightSymbols;
                            lastRightSymbol = tickets[i][j];
                        }
                        else
                        {
                            rightSymbols = 0;
                        }
                    }
                    if (leftSymbols >9 && rightSymbols > 9 && lastLeftSymbol == lastRightSymbol)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - {leftSymbols}{lastLeftSymbol} Jackpot!" );
                    }
                    else if (leftSymbols >= 6 && rightSymbols >= 6 && lastLeftSymbol == lastRightSymbol)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - {leftSymbols}{lastLeftSymbol}");
                    }
                    else if (true)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }

        }
    }
}
