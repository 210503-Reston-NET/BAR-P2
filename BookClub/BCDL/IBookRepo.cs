using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IBookRepo
    {
        Book AddBook(Book book);

        List<Book> GetAllBooks();

        List<Book> GetBookByAuthor(string author);

        Book GetBookByISBN(string isbn);

        Book GetBookByTitle(string title);

        Book UpdateBook(Book book);

        void DeleteBook(string isbn);

        bool BookExists(string isbn);
    }
}
