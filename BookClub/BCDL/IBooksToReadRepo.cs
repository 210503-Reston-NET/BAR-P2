using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IBooksToReadRepo
    {
        Task<BooksToRead> AddBooksReadAsync(BooksToRead book);
        Task<List<BooksToRead>> GetAllBooksReadAsync();
        Task<List<Book>> GetBooksReadByUserAsync(string email);
        Task<BooksToRead> UpdateBooksReadAsync(BooksToRead book);
        Task<BooksToRead> DeleteBooksReadAsync(int id);
    }
}
