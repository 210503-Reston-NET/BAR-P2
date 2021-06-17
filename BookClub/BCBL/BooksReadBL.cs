using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class BooksReadBL : IBooksReadBL
    {
        private readonly IBooksReadRepo _repo;
        public BooksReadBL(IBooksReadRepo repo)
        {
            _repo = repo;
        }

        public async Task<BooksRead> AddBooksReadAsync(BooksRead book)
        {
            return await _repo.AddBooksReadAsync(book);
        }

        public async Task<List<BooksRead>> GetAllBooksReadAsync()
        {
            return await _repo.GetAllBooksReadAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            return await _repo.GetBooksReadByUserAsync(email);
        }

    }
}
