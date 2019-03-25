using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawKeys = Console.ReadLine().Split('&');
            Regex regex = new Regex(@"^[A-Za-z0-9]+$");
            var processedKeys = new List<string>();

            for (int i = 0; i < rawKeys.Length; i++)
            {
                if (regex.IsMatch(rawKeys[i]) && rawKeys[i].Length == 16)
                {
                    StringBuilder sb = new StringBuilder();
                    string key = rawKeys[i];

                    for (int j = 0; j < 16; j++)
                    {
                        if (char.IsLetter(key[j]) && char.IsLower(key[j]))
                        {
                            sb.Append(char.ToUpper(key[j]));
                        }
                        else if (char.IsDigit(key[j]))
                        {
                            int num = int.Parse(key[j].ToString());
                            sb.Append(9 - num);
                        }
                        else if (char.IsUpper(key[j]))
                        {
                            sb.Append(key[j]);
                        }

                        if ((j + 1) % 4 == 0 && j + 1 != key.Length)
                        {
                            sb.Append('-');
                        }
                    }
                    processedKeys.Add(sb.ToString());
                }
                else if (regex.IsMatch(rawKeys[i]) && rawKeys[i].Length == 25)
                {
                    StringBuilder sb = new StringBuilder();
                    string key = rawKeys[i];

                    for (int j = 0; j < 25; j++)
                    {
                        if (char.IsLetter(key[j]) && char.IsLower(key[j]))
                        {
                            sb.Append(char.ToUpper(key[j]));
                        }
                        else if (char.IsDigit(key[j]))
                        {
                            int num = int.Parse(key[j].ToString());
                            sb.Append(9 - num);
                        }
                        else if (char.IsUpper(key[j]))
                        {
                            sb.Append(key[j]);
                        }

                        if ((j + 1) % 5 == 0 && j + 1 != key.Length)
                        {
                            sb.Append('-');
                        }
                    }
                    processedKeys.Add(sb.ToString());
                }
            }
            Console.WriteLine(string.Join(", ", processedKeys));
        }
    }
}
