using System;

namespace BCModel
{
    public class BookClub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BookId { get; set; }
        public BookClub() { }
        public BookClub(string name,string description,int bookId)
        {
            this.Name = name;
            this.Description=description
            this.BookId = bookId;
        }

        public BookClub(int Id,string name,string description, int bookId):this( name, description, bookId)
        {
            this.Name = name;
            this.Description=description
            this.BookId = bookId;
            this.Id = Id;
        }
        
        

    }
}
