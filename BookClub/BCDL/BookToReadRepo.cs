using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDL
{
    public class BookToReadRepo : IBooksToReadRepo
    {
        private readonly BookClubDBContext _context;

        public BookToReadRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public BooksToRead AddBooksRead(BooksToRead book)
        {

            _context.BooksToRead.Add(book);
            _context.SaveChanges();
            return book;
        }

        public BooksToRead DeleteBooksRead(int id)
        {
            BooksToRead toBeDeleted = _context.BooksToRead.FirstOrDefault(bookR => bookR.Id == id);
            if (toBeDeleted != null)
            {
                _context.BooksToRead.Remove(toBeDeleted);
                _context.SaveChanges();
            }

            return toBeDeleted;
        }

        public List<BooksToRead> GetAllBooksRead()
        {
            return _context.BooksToRead.Select(book => book).ToList();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            List<BooksToRead> booksRead = _context.BooksToRead.Where(book => book.Email.Equals(email)).Select(book => book).ToList();
            List<Book> books = new List<Book>();
            Book book;
            foreach (BooksToRead bookread in booksRead)
            {
                book = _context.Books.FirstOrDefault(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }

        public BooksToRead UpdateBooksRead(BooksToRead book)
        {
            _context.BooksToRead.Update(book);
            _context.SaveChanges();
            return book;
        }
    }
}
