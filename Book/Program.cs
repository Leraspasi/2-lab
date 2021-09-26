using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = new Title("Записки о Шерлоке Холмсе");
            var author = new Author("Конан Дойл");
            var content = new Content("Сборник из 11 детективных рассказов, написанных Артуром Конаном Дойлем, опубликованный в 1893 году");
            Book book = new Book(author, title, content);
            book.Show();
            Console.ReadKey();
        }
    }
    class Book
    {
        private readonly Author authorsName;
        private readonly Title title;
        private readonly Content content;

        public Book(Author author, Title title, Content content)
        {
            this.authorsName = author;
            this.title = title;
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Вся информация о книге: ");
            Console.Write("\n");
            authorsName.Show();
            title.Show();
            content.Show();

        }
    }
    class Title
    {
        private readonly string name;

        public Title(string titleName)
        {
            this.name = titleName;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Название книги - {name}");
        }
    }
    class Author
    {
        private readonly string bookAuthor;

        public Author(string author)
        {
            this.bookAuthor = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Имя автора - {bookAuthor}");
        }
    }
    class Content
    {
        private readonly string contents;

        public Content(string bookcontent)
        {
            this.contents = bookcontent;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Содержание книги - {contents}");
        }
    }
}
