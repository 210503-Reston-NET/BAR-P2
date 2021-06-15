using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCModel
{
    public class BooksRead
    {
        public BooksRead() { }
        public BooksRead(string userEmail, string isbn, int bookPages)
        {
            this.UserEmail = userEmail;
            this.ISBN = isbn;
            this.BookPages = bookPages;
        }

        public BooksRead(int booksReadId, string userEmail, string bookId, int bookPages) : this(userEmail, bookId, bookPages)
        {
            this.UserEmail = userEmail;
            this.ISBN = bookId;
            this.BooksReadId = booksReadId;
            this.BookPages = bookPages;
        }

        public int BooksReadId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("Book")]
        public string ISBN { get; set; }
        public Book Book { get; set; }
        public int BookPages { get; set; }

    }
}
