using System;

namespace BCModel
{
    public class FavoriteBook
    {
        public FavoriteBook()
        {
        }
        public FavoriteBook(string userid, string bookId)
        {
            this.Email = userid;
            this.ISBN = bookId;
        }

        public FavoriteBook(int Id, string userid, string bookId) : this(userid, bookId)
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
