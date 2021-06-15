using System;

namespace BCModel
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string isbn, string title, string author, string categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.CategoryName = categoryId;
        }

        public Book(int id, string isbn, string title, string author, string categoryId) : this(isbn, title, author, categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.CategoryName = categoryId;
            this.Id = id;
        }

        public Book(int id, string isbn, string title, string author, string categoryId, string img) : this(isbn, title, author, categoryId)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.CategoryName = categoryId;
            this.Id = id;
            this.ImageUrl = img;
        }

        public int Id {get;set;}
        public string ISBN {get;set;}
        public string Title {get;set;}
        public string Author {get;set;}
        public string CategoryName {get;set;}
        public string ImageUrl { get; set; }
    }
}
