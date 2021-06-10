using System;
using BCModel;
using BCDL;
using System.Collections.Generic;

namespace BCBL
{
    public class BookClubBL : IBookClubBL
    {

        private IBookClubRepo _repo;
        public BookClubBL(IBookClubRepo repo)
        {
            _repo = repo;
        }

        public BookClub AddBookClub(BookClub bookClub)
        {
            if (_repo.GetBookClub(bookClub) != null)
            {
                throw new Exception("Book Club already exists");
            }
            return _repo.AddBookClub(bookClub);
        }

        public BookClub DeleteBookClub(BookClub bookClub)
        {
            BookClub toBeDeleted = _repo.GetBookClub(bookClub);
            if (toBeDeleted != null)
            {
                return _repo.DeleteBookClub(bookClub);
            }
            throw new Exception("Book Club does not exist");
        }

        public List<BookClub> GetAllBookClubs()
        {
            return _repo.GetAllBookClubs();
        }

        public BookClub GetBookClub(BookClub bookClub)
        {
            return _repo.GetBookClub(bookClub);
        }

        public List<BookClub> GetBookClubByBook(string bookId)
        {
            return _repo.GetBookClubByBook(bookId);
        }

        public BookClub GetBookClubById(int bookClubId)
        {
            return _repo.GetBookClubById(bookClubId);
        }

        public BookClub UpdateBookClub(BookClub bookClub)
        {
            return _repo.UpdateBookClub(bookClub);
        }
    }
}
