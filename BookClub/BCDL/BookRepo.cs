using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class BookRepo : IBookRepo
    {
        private readonly BookClubDBContext _context;

        public BookRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            
            Category cat = await _context.Categories.AsNoTracking().FirstOrDefaultAsync(cate => cate.CategoryId.Equals(book.CategoryId));
            if (cat == null)
            {
                await _context.Categories.AddAsync(new Category(book.CategoryId));
            }
            
            _context.ChangeTracker.Clear();
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            
            
            return book;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            List<Book> book = await _context.Books.AsNoTracking().Select(book => book).ToListAsync();
            return book;
        }

        public async Task<List<Book>> GetBookByAuthorAsync(string author)
        {
            return await _context.Books.AsNoTracking().Where(book => book.Author == author).Select(book => book).ToListAsync();
        }

        public async Task<Book> GetBookByISBNAsync(string isbn)
        {
            return await _context.Books.AsNoTracking().FirstOrDefaultAsync(book => book.ISBN == isbn);
        }

        public async Task<Book> GetBookByTitleAsync(string title)
        {
            return await _context.Books.AsNoTracking().FirstOrDefaultAsync(book => book.Title == title);
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            _context.ChangeTracker.Clear();
            _context.Books.Update(book);
            await _context.SaveChangesAsync();

            return book;
        }

        public async void DeleteBookAsync(string isbn)
        {
            Book toBeDeleted = await _context.Books.AsNoTracking().FirstOrDefaultAsync(book => book.ISBN == isbn);

            if (toBeDeleted != null)
            {
                _context.Books.Remove(toBeDeleted);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> BookExistsAsync(string isbn)
        {
            Book book = await _context.Books.AsNoTracking().FirstOrDefaultAsync(book => book.ISBN == isbn);

            if (book == null) return false;
            else return true;
        }
    }
}
