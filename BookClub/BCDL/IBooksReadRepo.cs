using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IBooksReadRepo
    {
        Task<BooksRead> AddBooksReadAsync(BooksRead book);
        Task<List<BooksRead>> GetAllBooksReadAsync();
        Task<List<Book>> GetBooksReadByUserAsync(string email);

    }
}
