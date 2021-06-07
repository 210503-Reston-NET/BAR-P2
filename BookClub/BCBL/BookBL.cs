using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class BookBL : IBookBL
    {
        private IBookRepo _bookRepo;

        public BookBL(IBookRepo bookrepo)
        {
            _bookRepo = bookrepo;
        }

        public Book AddBook(Book book)
        {
            return _bookRepo.AddBook(book);
        }

        public void DeleteBook(string isbn)
        {
            _bookRepo.DeleteBook(isbn);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }

        public List<Book> GetBookByAuthor(string author)
        {
            return _bookRepo.GetBookByAuthor(author);
        }

        public Book GetBookByISBN(string isbn)
        {
            return _bookRepo.GetBookByISBN(isbn);
        }

        public Book GetBookByTitle(string title)
        {
            return _bookRepo.GetBookByTitle(title);
        }

        public Book UpdateBook(Book book)
        {
            bool exists = _bookRepo.BookExists(book.ISBN);

            if (exists) return _bookRepo.UpdateBook(book);
            else throw new Exception("Book doesn't exist in DB");

        }
    }
}
