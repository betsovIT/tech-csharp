using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> str = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                str.Add(input[i]);
            }

            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == '>')
                {
                    int toRemove = (int)char.GetNumericValue(str[i + 1]);

                    while (toRemove > 0)
                    {
                        if (str[i + 1] != '>')
                        {
                            str.RemoveAt(i + 1);
                            toRemove--;
                        }
                        else if (str[i + 1] == '>')
                        {
                            toRemove += (int)char.GetNumericValue(str[i + 2]);
                            i++;
                        }

                        if (i+1 >= str.Count)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("", str));
        }
    }
}
