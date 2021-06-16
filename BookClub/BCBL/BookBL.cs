using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;
using BCModel;

namespace BCBL
{
    public class BookBL : IBookBL
    {
        private readonly IBookRepo _bookRepo;

        public BookBL(IBookRepo bookrepo)
        {
            _bookRepo = bookrepo;
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            if (await _bookRepo.BookExistsAsync(book.ISBN))
            {
                return await _bookRepo.UpdateBookAsync(book);
            }
            return await _bookRepo.AddBookAsync(book);
        }

        public async Task<Book> DeleteBookAsync(string isbn)
        {
           return await _bookRepo.DeleteBookAsync(isbn);
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _bookRepo.GetAllBooksAsync();
        }

        public async Task<List<Book>> GetBookByAuthorAsync(string author)
        {
            return await _bookRepo.GetBookByAuthorAsync(author);
        }

        public async Task<Book> GetBookByISBNAsync(string isbn)
        {
            return await _bookRepo.GetBookByISBNAsync(isbn);
        }

        public async Task<Book> GetBookByTitleAsync(string title)
        {
            return await _bookRepo.GetBookByTitleAsync(title);
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            bool exists = await _bookRepo.BookExistsAsync(book.ISBN);

            if (exists) return await _bookRepo.UpdateBookAsync(book);
            else throw new Exception("Book doesn't exist in DB");
        }
    }
}
