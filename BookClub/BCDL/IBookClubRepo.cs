using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IBookClubRepo
    {
        Task<BookClub> AddBookClubAsync(BookClub bookClub);
        Task<BookClub> GetBookClubAsync(BookClub bookClub);
        Task<BookClub> GetBookClubByIdAsync(int bookClubId);
        Task<List<BookClub>> GetAllBookClubsAsync();
        Task<List<BookClub>> GetBookClubByBookAsync(string bookId);
        Task<BookClub> DeleteBookClubAsync(BookClub bookClub);
        Task<BookClub> UpdateBookClubAsync(BookClub bookClub);
        Task<List<BookClub>> GetBookClubsByUserAsync(string email);
        Task<List<BookClub>> GetBookClubByNameAsync(string name);
    }
}
