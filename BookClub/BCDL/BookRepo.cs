using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCModel;
using Microsoft.EntityFrameworkCore;

namespace BCDL
{
    public class BookRepo : IBookRepo
    {
        private readonly BookClubDBContext _context;

        public BookRepo(BookClubDBContext context)
        {
            _context = context;
        }

        public Book AddBook(Book book)
        {
            
            Category cat = _context.Categories.FirstOrDefault(cate => cate.Name.Equals(book.CategoryName));
            if (cat == null)
            {
                _context.Categories.Add(new Category(book.CategoryName));
            }
            
            _context.ChangeTracker.Clear();
            _context.Books.Add(book);
            _context.SaveChanges();
            
            
            return book;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> book = _context.Books.Select(book => book).ToList();
            return book;
        }

        public List<Book> GetBookByAuthor(string author)
        {
            return _context.Books.Where(book => book.Author == author).Select(book => book).ToList();
        }

        public Book GetBookByISBN(string isbn)
        {
            return _context.Books.FirstOrDefault(book => book.ISBN == isbn);
        }

        public Book GetBookByTitle(string title)
        {
            return _context.Books.FirstOrDefault(book => book.Title == title);
        }

        public Book UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();

            return book;
        }

        public void DeleteBook(string isbn)
        {
            Book toBeDeleted = _context.Books.FirstOrDefault(book => book.ISBN == isbn);

            if (toBeDeleted != null)
            {
                _context.Books.Remove(toBeDeleted);
                _context.SaveChanges();
            }
        }

        public bool BookExists(string isbn)
        {
            Book book = _context.Books.FirstOrDefault(book => book.ISBN == isbn);

            if (book == null) return false;
            else return true;
        }
    }
}
