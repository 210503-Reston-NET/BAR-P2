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
        BooksToRead AddBooksRead(BooksToRead book);
        List<BooksToRead> GetAllBooksRead();
        List<Book> GetBooksReadByUser(string email);
        BooksToRead UpdateBooksRead(BooksToRead book);
        BooksToRead DeleteBooksRead(int id);
    }
}
