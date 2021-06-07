using System;

namespace BCModel
{
    public class BooksToRead
    {
        public BooksToRead() { }
        public BooksToRead(User userid, Book bookId)
        {
            this.User = userid;
            this.Book = bookId;
        }

        public BooksToRead(int Id, User userid, Book bookId) : this(userid, bookId)
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
