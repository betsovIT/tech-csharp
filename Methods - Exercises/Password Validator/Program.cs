using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (IsPasswordBetween6And10Characters(password) && DoesPasswordContainTwoDigits(password) && DoesPasswordContainOnlyCorrectCharacters(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (IsPasswordBetween6And10Characters(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (DoesPasswordContainOnlyCorrectCharacters(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (DoesPasswordContainTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }            
        }
        static bool IsPasswordBetween6And10Characters(string str)
        {
            if (str.Length < 6 || str.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool DoesPasswordContainTwoDigits(string str)
        {
            int digitCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 47 && str[i] < 58)
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool DoesPasswordContainOnlyCorrectCharacters(string str)
        {
            bool conditionFullfiled = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]<48 || (str[i] > 57 && str[i] < 65) || (str[i] > 90 && str[i] < 97) || (str[i] > 57 && str[i] > 122))
                {
                    conditionFullfiled = false;
                }
                else
                {
                    continue;
                }
            }
            return conditionFullfiled;
        }
    }
}
