
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> listArticle = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Article inputClass = new Article(input[0], input[1], input[2]);

                listArticle.Add(inputClass);

            }

            string empty = Console.ReadLine();

            foreach (Article article in listArticle)
            {
                Console.WriteLine(article);
            }

        }
    }
}

