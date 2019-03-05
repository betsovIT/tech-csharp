using System;

namespace Google_Seaches
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            int[] userSearchesWords = new int[numberOfUsers];

            double moneyMade = 0;

            for (int i = 0; i < numberOfUsers; i++)
            {
                userSearchesWords[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= totalDays; i++)
            {
                for (int j = 0; j < userSearchesWords.Length; j++)
                {
                    //skip searches with more than 5 words
                    if (userSearchesWords[j] > 5)
                    {
                        continue;
                    }

                    if (userSearchesWords[j] == 1 && (j + 1) % 3 == 0)
                    {
                        moneyMade += 6 * moneyPerSearch;
                    }
                    else if (userSearchesWords[j] == 1 )
                    {
                        moneyMade += 2 * moneyPerSearch;
                    }
                    else if ((j+1) % 3 == 0)
                    {
                        moneyMade += 3 * moneyPerSearch;
                    }
                    else
                    {
                        moneyMade += moneyPerSearch;
                    }
                }
            }

            Console.WriteLine($"Total money earned for {totalDays} days: {moneyMade:F2}");
        }
    }
}
