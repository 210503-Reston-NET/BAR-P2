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
        BookClub DeleteBookClub(BookClub bookClub);
        BookClub UpdateBookClub(BookClub bookClub);
    }
}
