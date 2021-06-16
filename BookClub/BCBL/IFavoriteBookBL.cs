using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IFavoriteBookBL
    {
        Task<FavoriteBook> AddBooksReadAsync(FavoriteBook book);
        Task<List<FavoriteBook>> GetAllBooksReadAsync();
        Task<List<Book>> GetBooksReadByUserAsync(string email);
        Task<FavoriteBook> UpdateBooksReadAsync(FavoriteBook book);
        Task<FavoriteBook> DeleteBooksReadAsync(int id);
    }
}
