using System;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        [ForeignKey("Book")]
        public string ISBN { get; set; }

    }
}
