using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine(StringMultiplier(inputString,multiplier));
        }

        static string StringMultiplier(string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
