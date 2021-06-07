using System;

namespace BCModel
{
    public class BookClub
    {
        public BookClub()
        {
        }

        public BookClub(string name, string description, Book bookId)
        {
            this.Name = name;
            this.Description = description;
            this.Book = bookId;
        }

        public BookClub(int Id, string name, string description, Book bookId) : this(name, description, bookId)
        {
            this.Name = name;
            this.Description = description;
            this.Book = bookId;
            this.Id = Id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Book Book { get; set; }
    }
}
