using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Book
    {
        private Title CurrentBookTitle;
        private Author CurrentBookAuthor;
        private Content CurrentBookContent;

        public Book(string title, string author, string content)
        {
            CurrentBookTitle = new Title(title);
            CurrentBookAuthor = new Author(author);
            CurrentBookContent = new Content(content);
        }
        public void SetTitle(string title)
        {
            CurrentBookTitle.BookTitle = title;
        }
        public void SetAuthor(string author)
        {
            CurrentBookAuthor.BookAuthor = author;
        }
        public void SetContent(string content)
        {
            CurrentBookContent.BookContent = content;
        }

        public void Show()
        {
            CurrentBookTitle.Show();
            CurrentBookAuthor.Show();
            CurrentBookContent.Show();
            Console.ResetColor();
        }
    }
    class Title
    {
        public string BookTitle { get; set; }
        public Title(string text)
        {
            BookTitle = text;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(BookTitle);
        }
    }

    class Author
    {
        public string BookAuthor { get; set; }
        public Author(string text)
        {
            BookAuthor = text;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(BookAuthor);
        }
    }

    class Content
    {
        public string BookContent { get; set; }
        public Content(string text)
        {
            BookContent = text;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(BookContent);
        }
    }
}
