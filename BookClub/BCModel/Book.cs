using System;

namespace BCModel
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string isbn, string title, string author, Category categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Category = categoryId;
        }

        public Book(int id, string isbn, string title, string author, Category categoryId) : this(isbn, title, author, categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Category = categoryId;
            this.Id = id;
        }

        public int Id {get;set;}
        public string ISBN {get;set;}
        public string Title {get;set;}
        public string Author {get;set;}
        public Category Category {get;set;}
    }
}
