using System;
using System.Collections.Generic;
using BCModel;
using System.Linq;

namespace BCDL
{
    public class BookClubRepo : IBookClubRepo
    {
        private readonly BookClubDBContext _context;

        public BookClubRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public BookClub AddBookClub(BookClub bookClub)
        {
            _context.BookClubs.Add(bookClub);
            _context.SaveChanges();
            return bookClub;
        }

        public BookClub DeleteBookClub(BookClub bookClub)
        {
            BookClub toBeDeleted = _context.BookClubs.First(bc => bc.BookClubId == bookClub.BookClubId);
            _context.BookClubs.Remove(toBeDeleted);
            _context.SaveChanges();
            return bookClub;
        }

        public List<BookClub> GetAllBookClubs()
        {
            return _context.BookClubs.Select(bookClub => bookClub).ToList();
        }

        public BookClub GetBookClub(BookClub bookClub)
        {
            BookClub found = _context.BookClubs.FirstOrDefault(bc => bc.Name == bookClub.Name && bc.Description == bookClub.Description && bc.ISBN == bookClub.ISBN);
            if (found == null)
            {
                return null;
            }
            return new BookClub(found.Name, found.Description, found.ISBN, found.UserEmail);
        }

        public List<BookClub> GetBookClubByBook(string bookId)
        {
            return _context.BookClubs.Where(bc => bc.ISBN == bookId).Select(bc => bc).ToList();
        }

        public BookClub GetBookClubById(int bookClubId)
        {
            return _context.BookClubs.Find(bookClubId);
        }

        public BookClub UpdateBookClub(BookClub bookClub)
        {
            _context.BookClubs.Update(bookClub);
            _context.SaveChanges();
            return bookClub;
        }
    }
}
