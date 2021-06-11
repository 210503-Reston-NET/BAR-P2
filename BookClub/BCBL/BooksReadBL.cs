using BCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCDL;

namespace BCBL
{
    public class BooksReadBL : IBooksReadBL
    {
        private readonly IBooksReadRepo _repo;
        public BooksReadBL(IBooksReadRepo repo)
        {
            _repo = repo;
        }

        public BooksRead AddBooksRead(BooksRead book)
        {
            return _repo.AddBooksRead(book);
        }

        public BooksRead DeleteBooksRead(int id)
        {
            return _repo.DeleteBooksRead(id);
        }

        public List<BooksRead> GetAllBooksRead()
        {
            return _repo.GetAllBooksRead();
        }

        public List<Book> GetBooksReadByUser(string email)
        {
            return _repo.GetBooksReadByUser(email);
        }

        public BooksRead UpdateBooksRead(BooksRead book)
        {
            return _repo.UpdateBooksRead(book);
        }

    }
}
