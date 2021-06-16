using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using BCDL;

namespace BCBL
{
    public class BooksToReadBL : IBooksToReadBL
    {
        private readonly IBooksToReadRepo _repo;
        public BooksToReadBL(IBooksToReadRepo repo)
        {
            _repo = repo;
        }

        public BooksToRead AddBooksRead(BooksToRead book)
        {
            return _repo.AddBooksReadAsync(book);
        }

        public BooksToRead DeleteBooksRead(int id)
        {
            return _repo.DeleteBooksReadAsync(id);
        }

        public List<BooksToRead> GetAllBooksRead()
        {
            return _repo.GetAllBooksReadAsync();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            return _repo.GetBooksReadByUserAsync(email);
        }

        public BooksToRead UpdateBooksRead(BooksToRead book)
        {
            return _repo.UpdateBooksReadAsync(book);
        }
    }
}
