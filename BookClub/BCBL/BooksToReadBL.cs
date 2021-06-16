using System.Collections.Generic;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class BooksToReadBL : IBooksToReadBL
    {
        private readonly IBooksToReadRepo _repo;
        public BooksToReadBL(IBooksToReadRepo repo)
        {
            _repo = repo;
        }

        public async Task<BooksToRead> AddBooksReadAsync(BooksToRead book)
        {
            return await _repo.AddBooksReadAsync(book);
        }

        public async Task<BooksToRead> DeleteBooksReadAsync(int id)
        {
            return await _repo.DeleteBooksReadAsync(id);
        }

        public async Task<List<BooksToRead>> GetAllBooksReadAsync()
        {
            return await _repo.GetAllBooksReadAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            return await _repo.GetBooksReadByUserAsync(email);
        }

        public async Task<BooksToRead> UpdateBooksReadAsync(BooksToRead book)
        {
            return await _repo.UpdateBooksReadAsync(book);
        }
    }
}
