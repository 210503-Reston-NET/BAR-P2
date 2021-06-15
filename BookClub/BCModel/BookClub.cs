using System;

namespace BCModel
{
    public class BookClub
    {
        public BookClub()
        {
        }

        public BookClub(string name, string description, string isbn, string userEmail)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = isbn;
            this.UserEmail = userEmail;
        }

        public BookClub(int bookClubId, string name, string description, string isbn, string userEmail) : this(name, description, isbn, userEmail)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = isbn;
            this.BookClubId = bookClubId;
            this.UserEmail = userEmail;
        }

        public int BookClubId { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string Description { get; set; }
        
        public string ISBN { get; set; }
    }
}
