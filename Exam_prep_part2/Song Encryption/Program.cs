using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex artistRegex = new Regex(@"^[A-Z]{1}[a-z' ]*$");
            Regex songRegex = new Regex(@"^[A-Z ]+$");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string artist = input.Split(':')[0];
                string song = input.Split(':')[1];

                if (artistRegex.IsMatch(artist) && songRegex.IsMatch(song))
                {
                    int key = artist.Length;

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ':')
                        {
                            sb.Append('@');
                        }
                        else if (Char.IsLetter(input[i]) && char.IsLower(input[i]))
                        {
                            if (input[i] + key <= 122)
                            {
                                sb.Append((char)(input[i] + key));
                            }
                            else
                            {
                                sb.Append((char)(input[i] + key - 26));
                            }
                        }
                        else if (Char.IsLetter(input[i]) && char.IsUpper(input[i]))
                        {
                            if (input[i] + key <= 90)
                            {
                                sb.Append((char)(input[i] + key));
                            }
                            else
                            {
                                sb.Append((char)(input[i] + key - 26));
                            }
                        }
                        else
                        {
                            sb.Append(input[i]);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {sb.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
