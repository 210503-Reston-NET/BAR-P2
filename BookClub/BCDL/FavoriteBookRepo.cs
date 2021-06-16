using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class FavoriteBookRepo : IFavoriteBookRepo
    {
        private readonly BookClubDBContext _context;

        public FavoriteBookRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<FavoriteBook> AddBooksReadAsync(FavoriteBook book)
        {

            await _context.FavoriteBooks.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<FavoriteBook> DeleteBooksReadAsync(int id)
        {
            FavoriteBook toBeDeleted = await _context.FavoriteBooks.AsNoTracking().FirstOrDefaultAsync(bookR => bookR.FavoriteBookId == id);
            if (toBeDeleted != null)
            {
                _context.FavoriteBooks.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }

            return toBeDeleted;
        }

        public async Task<List<FavoriteBook>> GetAllBooksReadAsync()
        {
            return await _context.FavoriteBooks.AsNoTracking().Select(book => book).ToListAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            List<FavoriteBook> booksRead = await _context.FavoriteBooks.AsNoTracking().Where(book => book.UserEmail.Equals(email)).Select(book => book).ToListAsync();
            List<Book> books = new List<Book>();
            Book book;
            foreach (FavoriteBook bookread in booksRead)
            {
                book = await _context.Books.AsNoTracking().FirstOrDefaultAsync(bk => bk.ISBN.Equals(bookread.ISBN));
                books.Add(book);
            }

            return books;
        }

        public async Task<FavoriteBook> UpdateBooksReadAsync(FavoriteBook book)
        {
            _context.FavoriteBooks.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }
    }
}
