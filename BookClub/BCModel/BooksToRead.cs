using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCModel
{
    public class BooksToRead
    {
        public BooksToRead() { }
        public BooksToRead(string userEmail, string isbn)
        {
            this.UserEmail = userEmail;
            this.ISBN = isbn;
        }

        public BooksToRead(int booksToReadId, string userEmail, string isbn) : this(userEmail, isbn)
        {
            this.UserEmail = userEmail;
            this.ISBN = isbn;
            this.BooksToReadId = booksToReadId;
        }


        public int BooksToReadId { get; set; }
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        public User User { get; set; }
        [ForeignKey("Book")]
        public string ISBN { get; set; }
        public Book Book { get; set; }
    }
}
