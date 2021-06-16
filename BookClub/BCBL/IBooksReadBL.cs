using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IBooksReadBL
    {
        Task<BooksRead> AddBooksReadAsync(BooksRead book);
        Task<List<BooksRead>> GetAllBooksReadAsync();
        Task<List<Book>> GetBooksReadByUserAsync(string email);
        Task<BooksRead> UpdateBooksReadAsync(BooksRead book);
        Task<BooksRead> DeleteBooksReadAsync(int id);
    }
}
