using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;

namespace BCBL
{
    interface IBooksReadBL
    {
        BooksRead AddBooksRead(BooksRead book);
        List<BooksRead> GetAllBooksRead();
        List<BooksRead> GetBooksReadByUser(string email);
        BooksRead UpdateBooksRead(BooksRead book);
        BooksRead DeleteBooksRead(BooksRead book);
    }
}
