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

        public FavoriteBook AddBooksRead(FavoriteBook book)
        {
            return _repo.AddBooksReadAsync(book);
        }

        public FavoriteBook DeleteBooksRead(int id)
        {
            return _repo.DeleteBooksReadAsync(id);
        }

        public List<FavoriteBook> GetAllBooksRead()
        {
            return _repo.GetAllBooksReadAsync();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            return _repo.GetBooksReadByUserAsync(email);
        }

        public FavoriteBook UpdateBooksRead(FavoriteBook book)
        {
            return _repo.UpdateBooksReadAsync(book);
        }
    }
}
