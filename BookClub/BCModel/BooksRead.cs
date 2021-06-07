using System;

namespace BCModel
{
    public class BooksRead
    {
        public BooksRead() { }
        public BooksRead(int userid, Book bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
        }

        public BooksRead(int Id, int userid, Book bookId) : this(userid, bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
            this.Id = Id;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public Book BookId { get; set; }

    }
}
