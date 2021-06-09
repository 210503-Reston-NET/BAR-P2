using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IFavoriteBookRepo
    {
        FavoriteBook AddBooksRead(FavoriteBook book);
        List<FavoriteBook> GetAllBooksRead();
        List<Book> GetBooksReadByUser(string email);
        FavoriteBook UpdateBooksRead(FavoriteBook book);
        FavoriteBook DeleteBooksRead(int id);
    }
}
