using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[d-z#|{}]+$");
            string bookCode = Console.ReadLine();
            string[] specialString = Console.ReadLine().Split();

            if (!regex.IsMatch(bookCode))
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bookCode.Length; i++)
            {
                sb.Append((char)(bookCode[i] - 3));
            }

            string decodedBookCode = sb.ToString();

            string finalBookCode = decodedBookCode.Replace(specialString[0], specialString[1]);

            Console.WriteLine(finalBookCode);

        }
    }
}
