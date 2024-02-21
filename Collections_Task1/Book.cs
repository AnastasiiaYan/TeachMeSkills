using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task1
{
    internal class Book
    {
        public string title;
        public string author;
        public int publicationYear;
        public Book (string title, string author, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
        }
        public string info()
        {
            return $"Название: {title}, Автор: {author}, Год издания: {publicationYear}";
        }
    }
}
