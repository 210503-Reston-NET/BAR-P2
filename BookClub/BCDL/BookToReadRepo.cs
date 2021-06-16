using BCModel;
using Microsoft.EntityFrameworkCore;
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

        public async Task<BooksToRead> AddBooksReadAsync(BooksToRead book)
        {

            await _context.BooksToRead.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<BooksToRead> DeleteBooksReadAsync(int id)
        {
            BooksToRead toBeDeleted = await _context.BooksToRead.AsNoTracking().FirstOrDefaultAsync(bookR => bookR.BooksToReadId == id);
            if (toBeDeleted != null)
            {
                _context.BooksToRead.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }

            return toBeDeleted;
        }

        public async Task<List<BooksToRead>> GetAllBooksReadAsync()
        {
            return await _context.BooksToRead.AsNoTracking().Select(book => book).ToListAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            List<BooksToRead> booksRead = await _context.BooksToRead.AsNoTracking().Where(book => book.UserEmail.Equals(email)).Select(book => book).ToListAsync();
            List<Book> books = new List<Book>();
            Book book;
            foreach (BooksToRead bookread in booksRead)
            {
                book = await _context.Books.AsNoTracking().FirstOrDefaultAsync(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }

        public async Task<BooksToRead> UpdateBooksReadAsync(BooksToRead book)
        {
            _context.BooksToRead.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }
    }
}
