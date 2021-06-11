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
            return _repo.AddBooksRead(book);
        }

        public BooksToRead DeleteBooksRead(int id)
        {
            return _repo.DeleteBooksRead(id);
        }

        public List<BooksToRead> GetAllBooksRead()
        {
            return _repo.GetAllBooksRead();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            return _repo.GetBooksReadByUser(email);
        }

        public BooksToRead UpdateBooksRead(BooksToRead book)
        {
            return _repo.UpdateBooksRead(book);
        }
    }
}
