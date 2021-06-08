using System;

namespace BCModel
{
    public class BooksRead
    {
        public BooksRead() { }
        public BooksRead(string userid, string bookId)
        {
            this.User = userid;
            this.ISBN = bookId;
        }

        public BooksRead(int Id, string userid, string bookId) : this(userid, bookId)
        {
            this.User = userid;
            this.ISBN = bookId;
            this.Id = Id;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string ISBN { get; set; }

    }
}
