using System;

namespace BCModel
{
    public class BooksRead
    {
        public BooksRead() { }
        public BooksRead(User userid, Book bookId)
        {
            this.User = userid;
            this.Book = bookId;
        }

        public BooksRead(int Id, User userid, Book bookId) : this(userid, bookId)
        {
            this.User = userid;
            this.Book = bookId;
            this.Id = Id;
        }

        public int Id { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

    }
}
