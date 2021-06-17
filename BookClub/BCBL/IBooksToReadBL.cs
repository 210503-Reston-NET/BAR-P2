using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IBooksToReadBL
    {
        Task<BooksToRead> AddBooksReadAsync(BooksToRead book);
        Task<List<BooksToRead>> GetAllBooksReadAsync();
        Task<List<Book>> GetBooksReadByUserAsync(string email);
    }
}
