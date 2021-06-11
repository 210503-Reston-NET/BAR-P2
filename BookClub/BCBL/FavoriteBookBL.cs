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
            return _repo.AddBooksRead(book);
        }

        public FavoriteBook DeleteBooksRead(int id)
        {
            return _repo.DeleteBooksRead(id);
        }

        public List<FavoriteBook> GetAllBooksRead()
        {
            return _repo.GetAllBooksRead();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            return _repo.GetBooksReadByUser(email);
        }

        public FavoriteBook UpdateBooksRead(FavoriteBook book)
        {
            return _repo.UpdateBooksRead(book);
        }
    }
}
