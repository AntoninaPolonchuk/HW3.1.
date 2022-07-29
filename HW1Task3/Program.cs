using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Task3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Book book1 = new Book();
            book1.title1.TitleBook = "1984";
            book1.author1.AuthorBook = "Джордж Орвелл";
            book1.content1.ContentBook = "Антиутопия";

            book1.title1.Show();
            book1.author1.Show();
            book1.content1.Show();

            Console.ReadKey();
        }
    }

    public class Book
    {
        public Title title1 = new Title();
        public Author author1 = new Author();
        public Content content1 = new Content();

    }

     public class Title
    {
        string titleBook;

        public string TitleBook
        {
          set { titleBook = value; }
          get { return titleBook; }
        }


        public void Show()
        { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Название книги: " + titleBook);
        }
    }

    public class Author
    {
        string author;

        public string AuthorBook
        {
            set { author = value; }
            get { return author; }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Автор книги: " + author);
        }
    }

    public class Content
    {
        string content;
        public string ContentBook
        {
            set { content = value; }
            get { return content; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Краткое содержание книги: " + content);
        }
    }




}
