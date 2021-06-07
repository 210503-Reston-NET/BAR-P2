using System;

namespace BCModel
{
    public class FavoriteBook
    {
        public FavoriteBook()
        {
        }
        public FavoriteBook(User userid, Book bookId)
        {
            this.User = userid;
            this.Book = bookId;
        }

        public FavoriteBook(int Id, User userid, Book bookId) : this(userid, bookId)
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
