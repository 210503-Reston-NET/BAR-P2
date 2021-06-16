using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCDL
{
    public interface IBookRepo
    {
        Task<Book> AddBookAsync(Book book);

        Task<List<Book>> GetAllBooksAsync();

        Task<List<Book>> GetBookByAuthorAsync(string author);

        Task<Book> GetBookByISBNAsync(string isbn);

        Task<Book> GetBookByTitleAsync(string title);

        Task<Book> UpdateBookAsync(Book book);

        Task<Book> DeleteBookAsync(string isbn);

        Task<bool> BookExistsAsync(string isbn);
    }
}
