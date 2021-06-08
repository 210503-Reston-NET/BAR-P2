using System;

namespace BCModel
{
    public class BookClub
    {
        public BookClub()
        {
        }

        public BookClub(string name, string description, string bookId, string user)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = bookId;
            this.Email = user;
        }

        public BookClub(int Id, string name, string description, string bookId, string user) : this(name, description, bookId, user)
        {
            this.Name = name;
            this.Description = description;
            this.ISBN = bookId;
            this.Id = Id;
            this.Email = user;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        
        public string ISBN { get; set; }
    }
}
