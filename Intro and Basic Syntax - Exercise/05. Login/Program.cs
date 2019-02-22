using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string loginName = Console.ReadLine();
            string passwordGiven = Console.ReadLine();
            string password = "";

            for (int i = loginName.Length-1; i >= 0; i--)
            {
                password = password + loginName[i];
            }

            while (passwordGiven != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                passwordGiven = Console.ReadLine();
            }

            Console.WriteLine($"User {loginName} logged in.");
        }
    }
}
