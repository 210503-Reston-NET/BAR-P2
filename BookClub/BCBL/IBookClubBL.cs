using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IBookClubBL
    {
        Task<BookClub> AddBookClubAsync(BookClub bookClub);
        Task<BookClub> GetBookClubAsync(BookClub bookClub);
        Task<BookClub> GetBookClubByIdAsync(int bookClubId);
        Task<List<BookClub>> GetBookClubByBookAsync(string bookId);
        Task<List<BookClub>> GetAllBookClubsAsync();
        Task<BookClub> DeleteBookClubAsync(BookClub bookClub);
        Task<BookClub> UpdateBookClubAsync(BookClub bookClub);
        Task<List<BookClub>> GetBookClubsByUserAsync(string email);
    }
}
