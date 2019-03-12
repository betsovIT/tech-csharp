using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string company = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company,new List<string> {id});
                }
                else if (companies.ContainsKey(company) && !companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }

                input = Console.ReadLine();
            }

            var orderedComapnies = companies.OrderBy(n => n.Key);

            foreach (var item in orderedComapnies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var list in item.Value)
                {
                    Console.WriteLine($"-- {list}");
                }
            }
        }
    }
}
