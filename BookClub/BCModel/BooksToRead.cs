using System;

namespace BCModel
{
    public class BooksToRead
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public BooksToRead() { }
        public BooksToRead(int userid,int bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
        }

        public BooksToRead(int Id,int userid,int bookId):this( userid, bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
            this.Id = Id;
        }
        
        

    }
}
