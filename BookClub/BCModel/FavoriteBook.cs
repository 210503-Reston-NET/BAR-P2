using System;

namespace BCModel
{
    public class FavoriteBook
    {
        public FavoriteBook()
        {
        }
        public FavoriteBook(string userEmail, string isbn)
        {
            this.UserEmail = userEmail;
            this.ISBN = isbn;
        }

        public FavoriteBook(int favoriteBookId, string userEmail, string isbn) : this(userEmail, isbn)
        {
            this.UserEmail = userEmail;
            this.ISBN = isbn;
            this.FavoriteBookId = favoriteBookId;
        }

        public int FavoriteBookId { get; set; }
        public string UserEmail { get; set; }
        public string ISBN { get; set; } 

    }
}
