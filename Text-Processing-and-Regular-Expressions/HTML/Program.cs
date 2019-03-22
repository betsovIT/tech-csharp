using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string heading = Console.ReadLine();
            Console.WriteLine(@"<h1>");
            Console.WriteLine($"\t{heading}");
            Console.WriteLine(@"</h1>");
            string article = Console.ReadLine();
            Console.WriteLine(@"<article>");
            Console.WriteLine($"\t{article}");
            Console.WriteLine(@"</article>");
            while (true)
            {
                string contentInput = Console.ReadLine();
                if (contentInput == "end of comments")
                {
                    break;
                }
                Console.WriteLine(@"<div>");
                Console.WriteLine($"\t{contentInput}");
                Console.WriteLine(@"</div>");
            }
        }
    }
}
