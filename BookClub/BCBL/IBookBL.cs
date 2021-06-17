using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IBookBL
    {
        Task<Book> AddBookAsync(Book book);

        Task<List<Book>> GetAllBooksAsync();

        Task<List<Book>> GetBookByAuthorAsync(string author);

        Task<Book> GetBookByISBNAsync(string isbn);

        Task<Book> GetBookByTitleAsync(string title);
    }
}
