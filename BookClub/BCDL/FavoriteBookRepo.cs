using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public class FavoriteBookRepo : IFavoriteBookRepo
    {
        private readonly BookClubDBContext _context;

        public FavoriteBookRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public FavoriteBook AddBooksRead(FavoriteBook book)
        {

            _context.FavoriteBooks.Add(book);
            _context.SaveChanges();
            return book;
        }

        public FavoriteBook DeleteBooksRead(int id)
        {
            FavoriteBook toBeDeleted = _context.FavoriteBooks.FirstOrDefault(bookR => bookR.FavoriteBookId == id);
            if (toBeDeleted != null)
            {
                _context.FavoriteBooks.Remove(toBeDeleted);
                _context.SaveChanges();
            }

            return toBeDeleted;
        }

        public List<FavoriteBook> GetAllBooksRead()
        {
            return _context.FavoriteBooks.Select(book => book).ToList();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            List<FavoriteBook> booksRead = _context.FavoriteBooks.Where(book => book.UserEmail.Equals(email)).Select(book => book).ToList();
            List<Book> books = new List<Book>();
            Book book;
            foreach (FavoriteBook bookread in booksRead)
            {
                book = _context.Books.FirstOrDefault(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }

        public FavoriteBook UpdateBooksRead(FavoriteBook book)
        {
            _context.FavoriteBooks.Update(book);
            _context.SaveChanges();
            return book;
        }
    }
}
