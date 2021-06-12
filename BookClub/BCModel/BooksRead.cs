using System;

namespace BCModel
{
    public class BooksRead
    {
        public BooksRead() { }
        public BooksRead(string userid, string bookId, int pages)
        {
            this.User = userid;
            this.ISBN = bookId;
            this.Pages = pages;
        }

        public BooksRead(int Id, string userid, string bookId, int pages) : this(userid, bookId, pages)
        {
            this.User = userid;
            this.ISBN = bookId;
            this.Id = Id;
            this.Pages = pages;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }

    }
}
