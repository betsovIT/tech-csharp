using System;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach (string name in input)
            {
                bool isValid = true;
                if (name.Length>=3 && name.Length<=16)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] < 45 )
                        {
                            isValid = false;
                        }
                        else if (name[i] > 45 && name[i]<48)
                        {
                            isValid = false;
                        }
                        else if (name[i] > 57 && name[i] < 65)
                        {
                            isValid = false;
                        }
                        else if (name[i] > 90 && name[i] < 95)
                        {

                            isValid = false;
                        }
                        else if (name[i] > 95 && name[i] < 97)
                        {
                            isValid = false;
                        }
                        else if (name[i] > 123)
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

                

            
        }
    }
}
