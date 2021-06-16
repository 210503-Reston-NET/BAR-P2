using System;
using System.Collections.Generic;
using BCModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class BookClubRepo : IBookClubRepo
    {
        private readonly BookClubDBContext _context;

        public BookClubRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public async Task<BookClub> AddBookClubAsync(BookClub bookClub)
        {
            await _context.BookClubs.AddAsync(bookClub);
            await _context.SaveChangesAsync();
            return bookClub;
        }

        public async Task<BookClub> DeleteBookClubAsync(BookClub bookClub)
        {
            BookClub toBeDeleted = await _context.BookClubs.AsNoTracking().FirstAsync(bc => bc.BookClubId == bookClub.BookClubId);
            _context.BookClubs.Remove(toBeDeleted);
            await _context.SaveChangesAsync();
            return bookClub;
        }

        public async Task<List<BookClub>> GetAllBookClubsAsync()
        {
            return await _context.BookClubs.AsNoTracking().Select(bookClub => bookClub).ToListAsync();
        }

        public async Task<BookClub> GetBookClubAsync(BookClub bookClub)
        {
            BookClub found = await _context.BookClubs.AsNoTracking().FirstOrDefaultAsync(bc => bc.Name == bookClub.Name && bc.Description == bookClub.Description && bc.ISBN == bookClub.ISBN);
            if (found == null)
            {
                return null;
            }
            return new BookClub(found.Name, found.Description, found.ISBN, found.UserEmail);
        }

        public async Task<List<BookClub>> GetBookClubByBookAsync(string bookId)
        {
            return await _context.BookClubs.AsNoTracking().Where(bc => bc.ISBN == bookId).Select(bc => bc).ToListAsync();
        }

        public async Task<BookClub> GetBookClubByIdAsync(int bookClubId)
        {
            return await _context.BookClubs.FindAsync(bookClubId);
        }

        public async Task<BookClub> UpdateBookClubAsync(BookClub bookClub)
        {
            _context.BookClubs.Update(bookClub);
            await _context.SaveChangesAsync();
            return bookClub;
        }
    }
}
