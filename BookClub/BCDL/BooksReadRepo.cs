using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class BooksReadRepo : IBooksReadRepo
    {
        private readonly BookClubDBContext _context;

        public BooksReadRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public BooksRead AddBooksRead(BooksRead book)
        {
            User user = _context.Users.FirstOrDefault(usr => usr.Email.Equals(book.User));

            if (user != null)
            {
                int pagesRead = user.PagesRead + book.Pages;
                user.PagesRead = pagesRead;
                _context.Users.Update(user);
                _context.SaveChanges();
            }

            _context.BooksRead.Add(book);
            _context.SaveChanges();
            return book;
        }

        public BooksRead DeleteBooksRead(int id)
        {
            BooksRead toBeDeleted = _context.BooksRead.FirstOrDefault(bookR => bookR.Id == id);
            if (toBeDeleted != null)
            {
                _context.BooksRead.Remove(toBeDeleted);
                _context.SaveChanges();
            }

            return toBeDeleted;
        }

        public List<BooksRead> GetAllBooksRead()
        {
            return _context.BooksRead.Select(book => book).ToList();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            List<BooksRead> booksRead = _context.BooksRead.Where(book => book.User.Equals(email)).Select(book => book).ToList();
            List<Book> books = new List<Book>();
            Book book;
            foreach(BooksRead bookread in booksRead)
            {
                book = _context.Books.FirstOrDefault(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }

        public BooksRead UpdateBooksRead(BooksRead book)
        {
            _context.BooksRead.Update(book);
            _context.SaveChanges();
            return book;
        }
    }
}
