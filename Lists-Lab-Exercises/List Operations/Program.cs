using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", listInt));
                    break;
                }

                if (input[0] == "Add")
                {
                    listInt.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) > listInt.Count - 1 || int.Parse(input[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    listInt.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) > listInt.Count - 1 || int.Parse(input[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    listInt.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Shift")
                {
                    if (input[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            listInt.Add(listInt[0]);
                            listInt.RemoveAt(0);
                        }
                    }
                    else if (input[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            listInt.Insert(0, listInt[listInt.Count - 1]);
                            listInt.RemoveAt(listInt.Count - 1);
                        }
                    }
                }
            }
        }
    }
}
