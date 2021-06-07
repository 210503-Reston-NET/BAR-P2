using System;

namespace BCModel
{
    public class BooksRead
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public BooksRead() { }
        public BooksRead(int userid,int bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
        }

        public BooksRead(int Id,int userid,int bookId):this( userid, bookId)
        {
            this.UserId = userid;
            this.BookId = bookId;
            this.Id = Id;
        }
        
        

    }
}
