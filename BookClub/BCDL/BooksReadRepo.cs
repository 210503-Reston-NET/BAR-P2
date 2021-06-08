using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public class BooksReadRepo : IBooksReadRepo
    {
        private BookClubDBContext _context;

        public BooksReadRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public BooksRead AddBooksRead(BooksRead book)
        {
            _context.BooksRead.Add(book);
            _context.SaveChanges();
            return book;
        }

        public BooksRead DeleteBooksRead(BooksRead book)
        {
            BooksRead toBeDeleted = _context.BooksRead.FirstOrDefault(bookR => bookR.Id == book.Id);
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

        public List<BooksRead> GetBooksReadByUser(string email)
        {
            return _context.BooksRead.Where(book => book.User.Email.Equals(email)).Select(book => book).ToList();
        }

        public BooksRead UpdateBooksRead(BooksRead book)
        {
            _context.BooksRead.Update(book);
            _context.SaveChanges();
            return book;
        }
    }
}
