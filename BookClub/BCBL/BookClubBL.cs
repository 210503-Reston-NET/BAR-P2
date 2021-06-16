using System;
using BCModel;
using BCDL;
using System.Collections.Generic;

namespace BCBL
{
    public class BookClubBL : IBookClubBL
    {

        private readonly IBookClubRepo _repo;
        public BookClubBL(IBookClubRepo repo)
        {
            _repo = repo;
        }

        public BookClub AddBookClub(BookClub bookClub)
        {
            if (_repo.GetBookClubAsync(bookClub) != null)
            {
                throw new Exception("Book Club already exists");
            }
            return _repo.AddBookClubAsync(bookClub);
        }

        public BookClub DeleteBookClub(BookClub bookClub)
        {
            BookClub toBeDeleted = _repo.GetBookClubAsync(bookClub);
            if (toBeDeleted != null)
            {
                return _repo.DeleteBookClubAsync(bookClub);
            }
            throw new Exception("Book Club does not exist");
        }

        public List<BookClub> GetAllBookClubs()
        {
            return _repo.GetAllBookClubsAsync();
        }

        public BookClub GetBookClub(BookClub bookClub)
        {
            return _repo.GetBookClubAsync(bookClub);
        }

        public List<BookClub> GetBookClubByBook(string bookId)
        {
            return _repo.GetBookClubByBookAsync(bookId);
        }

        public BookClub GetBookClubById(int bookClubId)
        {
            return _repo.GetBookClubByIdAsync(bookClubId);
        }

        public BookClub UpdateBookClub(BookClub bookClub)
        {
            return _repo.UpdateBookClubAsync(bookClub);
        }
    }
}
