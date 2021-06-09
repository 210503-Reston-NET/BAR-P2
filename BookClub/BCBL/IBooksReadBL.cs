using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    public interface IBooksReadBL
    {
        BooksRead AddBooksRead(BooksRead book);
        List<BooksRead> GetAllBooksRead();
        List<Book> GetBooksReadByUser(string email);
        BooksRead UpdateBooksRead(BooksRead book);
        BooksRead DeleteBooksRead(int id);
    }
}
