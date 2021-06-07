using System;

namespace BCModel
{
    public class BooksToRead
    {
        public BooksToRead() { }
        public BooksToRead(User userid, Book bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
        }

        public BooksToRead(int Id, User userid, Book bookId) : this(userid, bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
            this.Id = Id;
        }


        public int Id { get; set; }
        public User UserId { get; set; }
        public Book BookId { get; set; }
    }
}
