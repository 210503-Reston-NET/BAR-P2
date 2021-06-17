using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using BCDL;

namespace BCBL
{
    public class FavoriteBookBL : IFavoriteBookBL
    {
        private readonly IFavoriteBookRepo _repo;
        public FavoriteBookBL(IFavoriteBookRepo repo)
        {
            _repo = repo;
        }

        public async Task<FavoriteBook> AddBooksReadAsync(FavoriteBook book)
        {
            return await _repo.AddBooksReadAsync(book);
        }

        public async Task<List<FavoriteBook>> GetAllBooksReadAsync()
        {
            return await _repo.GetAllBooksReadAsync();
        }

        public async Task<List<Book>> GetBooksReadByUserAsync(string email)
        {
            return await _repo.GetBooksReadByUserAsync(email);
        }
    }
}
