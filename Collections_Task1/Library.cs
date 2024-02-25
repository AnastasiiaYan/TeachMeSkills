using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task1
{
    internal class Library 
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author, int publicationYear)
        {
            books.Add(new Book(title, author, publicationYear));
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("В библиотеке нет книг");
            }
            else
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Info());
                }
            }                
        }

        public void FindByAuthor(string author)
        {
            foreach (Book book in books)
            {
                if (book.author == author)
                {
                    Console.WriteLine(book.Info());
                }
            }
        }

        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title)
                {
                    books.Remove(books[i]);
                    break;
                }
            }
        }

        public void Exit()
        {
            Console.WriteLine("Выполнен выход из библиотеки.");
            Environment.Exit(0);
        }        
    }
}
