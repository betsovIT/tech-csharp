using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (CheckIfPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            
        }
        static bool CheckIfPalindrome(string str)
        {
            bool iSPalindrome = true;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    iSPalindrome = false;
                }
                else
                {
                    continue;
                }
            }

            return iSPalindrome;
        }
    }
}
