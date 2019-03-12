using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();            
            while (true)
            {
                string metal = Console.ReadLine();
                if (metal == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(metal))
                {
                    resources.Add(metal, 0);
                }

                resources[metal] += quantity;
            }
            foreach (var metals in resources)
            {
                Console.WriteLine($"{metals.Key} -> {metals.Value}");
            }
        }
    }
}
