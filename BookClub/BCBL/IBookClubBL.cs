using System;
using System.Collections.Generic;
using BCModel;

namespace BCBL
{
    public interface IBookClubBL
    {
        BookClub AddBookClub(BookClub bookClub);
        BookClub GetBookClub(BookClub bookClub);
        BookClub GetBookClubById(int bookClubId);
        List<BookClub> GetBookClubByBook(string bookId);
        List<BookClub> GetAllBookClubs();
        BookClub DeleteBookClub(BookClub bookClub);
        BookClub UpdateBookClub(BookClub bookClub);
    }
}
