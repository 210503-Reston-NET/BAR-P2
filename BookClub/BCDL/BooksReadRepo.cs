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

        public async Task<BooksRead> AddBooksReadAsync(BooksRead book)
        {
            User user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.UserEmail.Equals(book.UserEmail));

            if (user != null)
            {
                int pagesRead = user.PagesRead + book.BookPages;
                user.PagesRead = pagesRead;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }

            await _context.BooksRead.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<List<BooksRead>> GetAllBooksReadAsync()
        {
            return await _context.BooksRead.AsNoTracking().Select(book => book).ToListAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            List<BooksRead> booksRead = await _context.BooksRead.AsNoTracking().Where(book => book.UserEmail.Equals(email)).Select(book => book).ToListAsync();
            List<Book> books = new List<Book>();
            Book book;
            foreach(BooksRead bookread in booksRead)
            {
                book = await _context.Books.FirstOrDefaultAsync(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }
    }
}
