using System;

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
        public string UserEmail { get; set; }
        public string ISBN { get; set; }
    }
}
