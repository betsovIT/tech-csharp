using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[2] == "not")
                {
                    if (guestList.Contains(input[0]))
                    {
                        guestList.Remove(input[0]);
                    }
                    else if (!guestList.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }                    
                }
                else if (input[2] == "going!")
                {
                    if (guestList.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else if (!guestList.Contains(input[0]))
                    {
                        
                        guestList.Add(input[0]);
                    }
                }
            }
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
