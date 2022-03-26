using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {   
        public Article(string title , string content , string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string input)
        {
            return Content = input;
        }

        public string ChangeAuthor(string input)
        {
            return Author = input;
        }
        public string Rename(string input)
        {
            return Title = input;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article inputClass = new Article(input[0],input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] change = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string newString = string.Empty;
                for (int z = 1; z < change.Length; z++)
                {
                    newString += change[z];
                    if (z != change.Length - 1)
                    {
                        newString += ' ';
                    }
                }

                switch (change[0])
                {
                    case "Edit:":
                        inputClass.Edit(newString);
                            break;
                    case "ChangeAuthor:":
                        inputClass.ChangeAuthor(newString);
                        break;
                    case "Rename:":
                        inputClass.Rename(newString);
                        break;
                }
            }
            Console.WriteLine($"{inputClass.Title} - {inputClass.Content}: {inputClass.Author}");
        }
    }
}
