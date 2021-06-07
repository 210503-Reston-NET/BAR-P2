using System;

namespace BCModel
{
    public class FavoriteBook
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public FavoriteBook() { }
        public FavoriteBook(int userid,int bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
        }

        public FavoriteBook(int Id,int userid,int bookId):this( userid, bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
            this.Id = Id;
        }
        
        

    }
}
