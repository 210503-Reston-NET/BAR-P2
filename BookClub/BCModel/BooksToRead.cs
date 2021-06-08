using System;

namespace BCModel
{
    public class BooksToRead
    {
        public BooksToRead() { }
        public BooksToRead(string userid, string bookId)
        {
            this.Email = userid;
            this.ISBN = bookId;
        }

        public BooksToRead(int Id, string userid, string bookId) : this(userid, bookId)
        {
            this.Email = userid;
            this.ISBN = bookId;
            this.Id = Id;
        }


        public int Id { get; set; }
        public string Email { get; set; }
        public string ISBN { get; set; }
    }
}
