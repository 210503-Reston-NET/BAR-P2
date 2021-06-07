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
            this.UserId = userid;
            this.BookId = bookId;
        }

        public FavoriteBook(int Id, User userid, Book bookId) : this(userid, bookId)
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
