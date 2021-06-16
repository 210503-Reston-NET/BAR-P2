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
        private readonly IBookRepo _bookRepo;

        public BookBL(IBookRepo bookrepo)
        {
            _bookRepo = bookrepo;
        }

        public Book AddBook(Book book)
        {
            if (_bookRepo.BookExistsAsync(book.ISBN))
            {
                return _bookRepo.UpdateBookAsync(book);
            }
            return _bookRepo.AddBookAsync(book);
        }

        public void DeleteBook(string isbn)
        {
            _bookRepo.DeleteBookAsync(isbn);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAllBooksAsync();
        }

        public List<Book> GetBookByAuthor(string author)
        {
            return _bookRepo.GetBookByAuthorAsync(author);
        }

        public Book GetBookByISBN(string isbn)
        {
            return _bookRepo.GetBookByISBNAsync(isbn);
        }

        public Book GetBookByTitle(string title)
        {
            return _bookRepo.GetBookByTitleAsync(title);
        }

        public Book UpdateBook(Book book)
        {
            bool exists = _bookRepo.BookExistsAsync(book.ISBN);

            if (exists) return _bookRepo.UpdateBookAsync(book);
            else throw new Exception("Book doesn't exist in DB");
        }
    }
}
