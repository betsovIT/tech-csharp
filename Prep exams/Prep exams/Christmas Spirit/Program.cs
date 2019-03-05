using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            byte allowedQuantity = byte.Parse(Console.ReadLine());
            byte days = byte.Parse(Console.ReadLine());

            byte ornamentPrice = 2;
            byte treeSkirtPrice = 5;
            byte treeGarlandsPrice = 3;
            byte treeLightsPrice = 15;

            byte daysPast = 1;
            int budget = 0;
            byte spirit = 0;

            while (daysPast <= days)
            {
                bool divByThree = false;
                if (daysPast % 11 == 0)
                {
                    allowedQuantity += 2;
                }
                if (daysPast % 2 == 0)
                {
                    budget += ornamentPrice * allowedQuantity;
                    spirit += 5;
                }
                if (daysPast % 3 == 0)
                {
                    budget += treeSkirtPrice * allowedQuantity;
                    budget += treeGarlandsPrice * allowedQuantity;
                    spirit += 13;
                    divByThree = true;
                }
                if (daysPast % 5 == 0)
                {
                    budget += treeLightsPrice * allowedQuantity;
                    spirit += 17;
                    if (divByThree)
                    {
                        spirit += 30;
                    }
                }
                if (daysPast % 10 == 0)
                {
                    spirit -= 20;
                    budget += treeSkirtPrice;
                    budget += treeGarlandsPrice;
                    budget += treeLightsPrice;
                }

                if (daysPast == days && daysPast % 10 == 0)
                {
                    spirit -= 30;
                }
                daysPast++;
            }

            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
