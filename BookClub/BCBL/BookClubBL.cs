using System;
using BCModel;
using BCDL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCBL
{
    public class BookClubBL : IBookClubBL
    {

        private readonly IBookClubRepo _repo;
        public BookClubBL(IBookClubRepo repo)
        {
            _repo = repo;
        }

        public async Task<BookClub> AddBookClubAsync(BookClub bookClub)
        {
            if (await _repo.GetBookClubAsync(bookClub) != null)
            {
                throw new Exception("Book Club already exists");
            }
            return await _repo.AddBookClubAsync(bookClub);
        }

        public async Task<BookClub> DeleteBookClubAsync(BookClub bookClub)
        {
            BookClub toBeDeleted = await _repo.GetBookClubAsync(bookClub);
            if (toBeDeleted != null)
            {
                return await _repo.DeleteBookClubAsync(bookClub);
            }
            throw new Exception("Book Club does not exist");
        }

        public async Task<List<BookClub>> GetAllBookClubsAsync()
        {
            return await _repo.GetAllBookClubsAsync();
        }

        public async Task<BookClub> GetBookClubAsync(BookClub bookClub)
        {
            return await _repo.GetBookClubAsync(bookClub);
        }

        public async Task<List<BookClub>> GetBookClubByBookAsync(string bookId)
        {
            return await _repo.GetBookClubByBookAsync(bookId);
        }

        public async Task<BookClub> GetBookClubByIdAsync(int bookClubId)
        {
            return await _repo.GetBookClubByIdAsync(bookClubId);
        }

        public async Task<BookClub> UpdateBookClubAsync(BookClub bookClub)
        {
            return await _repo.UpdateBookClubAsync(bookClub);
        }
    }
}
