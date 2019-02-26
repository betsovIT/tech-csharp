using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Article article = new Article();
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                articles.Add(article);
            }
            string sorter = Console.ReadLine();

            if (sorter == "title")
            {
                articles.Sort((x, y) => x.Title.CompareTo(y.Title));
            }
            else if (sorter == "content")
            {
                articles.Sort((x, y) => x.Content.CompareTo(y.Content));
            }
            else if (sorter == "author")
            {
                articles.Sort((x, y) => x.Author.CompareTo(y.Author));
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }

            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
