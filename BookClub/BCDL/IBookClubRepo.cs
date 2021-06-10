using System;
using System.Collections.Generic;
using BCModel;

namespace BCDL
{
    public interface IBookClubRepo
    {
        BookClub AddBookClub(BookClub bookClub);
        BookClub GetBookClub(BookClub bookClub);
        BookClub GetBookClubById(int bookClubId);
        List<BookClub> GetAllBookClubs();
        List<BookClub> GetBookClubByBook(string bookId);
        BookClub DeleteBookClub(BookClub bookClub);
        BookClub UpdateBookClub(BookClub bookClub);
    }
}
